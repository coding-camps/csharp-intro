using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace UIControLib
{
    public partial class RoundRect : Control
    {
        #region 属性: int BorderWidth

        private int _borderWidth;

        [Category("自定义属性")]
        [Description("边框宽度")]
        [DefaultValue(5)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = Math.Max(0, value);
                Invalidate();
            }
        }

        #endregion

        #region 属性：int BorderRadius

        private int _borderRadius;

        [Category("自定义属性")]
        [Description("圆角大小")]
        [DefaultValue(10)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        #endregion

        #region 属性：Color BorderColor

        private Color _borderColor;

        [Category("自定义属性")]
        [Description("边框颜色")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        #endregion

        #region 属性：Color FillColor

        private Color _fillColor;

        [Category("自定义属性")]
        [Description("边框颜色")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FillColor
        {
            get => _fillColor;
            set
            {
                _fillColor = value;
                Invalidate();
            }
        }

        #endregion


        public RoundRect()
        {
            InitializeComponent();
            // 设计器中避免在构造函数中调用 Invalidate()
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            // 控件默认值
            this.BorderWidth = 5;
            this.BorderRadius = 10;
            this.BorderColor = Color.DarkGray;
            this.FillColor = this.BackColor;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // 设计时保护：避免在无效尺寸下绘制
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;
            /*

            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 创建圆角矩形路径
            GraphicsPath path = GetRoundRectPath(ClientRectangle, BorderRadius);

            // 绘制边框
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                g.DrawPath(pen, path);
            }

            //// 填充背景
            //using (SolidBrush brush = new SolidBrush(this.FillColor))
            //{
            //    g.FillPath(brush, path);
            //}

            path.Dispose();
            */

            /*
            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderWidth, -BorderWidth);
            int smoothSize = 2;
            if (BorderWidth > 0) smoothSize = BorderWidth;

            if (BorderWidth > 2)
            {
                using (GraphicsPath pathSurface = CreateRoundedRectanglePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = CreateRoundedRectanglePath(rectBorder, BorderRadius - BorderWidth))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderWidth))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    // pe.Graphics.FillPath(new SolidBrush(Color.Blue), pathSurface);
                    // pe.Graphics.FillPath(new SolidBrush(Color.LightBlue), pathBorder);
                    // Region = new Region(pathSurface);
                    pe.Graphics.DrawPath(penSurface, pathSurface);
                    if (BorderWidth >= 1)
                        pe.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            */

            ///*
            // 设计时保护：避免在无效尺寸下绘制
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 创建圆角矩形路径
            GraphicsPath path = GetRoundRectPath(ClientRectangle, BorderRadius);

            // 绘制边框 //BorderColor
            using (Pen pen = new Pen(Color.Transparent, BorderWidth))
            {
                g.DrawPath(pen, path);
            }

            // 填充背景 //FillColor
            using (SolidBrush brush = new SolidBrush(this.BorderColor))
            {
                g.FillPath(brush, path);
            }

            #region xxx
            Rectangle rectInner = Rectangle.Inflate(ClientRectangle, -BorderWidth, -BorderWidth);
            int innerBorderWidth = BorderRadius - BorderWidth;
            if(innerBorderWidth < 0)
            {
                innerBorderWidth = 0;
            }
            GraphicsPath pathInner = innerBorderWidth == 0 ? path : GetRoundRectPath(rectInner, innerBorderWidth);
            using(SolidBrush brush = new SolidBrush(this.FillColor))
            {
                g.FillPath (brush, pathInner);
            }
            #endregion


            path.Dispose();
            //*/
        }

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    // 防止背景被重复绘制
        //    base.OnPaintBackground(e);
        //}

        private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
        {
            #region 正确绘制圆角矩形区域

            GraphicsPath path = new GraphicsPath();


            //if (radius <= 0)
            //{
            //    Point loc = new Point(rect.X, rect.Y);
            //    Size size = new Size(rect.Width, rect.Height);
            //    Rectangle rect0 = new Rectangle(loc, size);
            //    this._borderColor = Color.Red;
            //    path.AddRectangle(rect0);
            //    return path;
            //}

            //// 防止圆角超过控件尺寸
            //radius = Math.Min(radius, Math.Min(rect.Width, rect.Height));

            float diameter = radius * 2F;

            // 四个圆角弧线
            // 右下
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // 左下
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            // 左上
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // 右上
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

            // 连接四条直线
            path.CloseFigure();
            //// 闭合路径中所有开放图形，并形成新图形
            //path.CloseAllFigures();
            return path;

            #endregion
        }

        private GraphicsPath MakeRoundRectPath(Rectangle rect, int radius)
        {
            #region 正确绘制圆角矩形区域

            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                Point loc = new Point(rect.X, rect.Y);
                Size size = new Size(rect.Width - 30, rect.Height - 30);
                Rectangle rect0 = new Rectangle(loc, size);
                this._borderColor = Color.Red;
                path.AddRectangle(rect0);
                return path;
            }

            int offset = 0;

            // 防止圆角超过控件尺寸
            radius = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2 - offset);

            float diameter = radius * 2F;

            // 四个圆角弧线
            // 左上
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // 右上
            path.AddArc(rect.Right - diameter - offset, rect.Y, diameter, diameter, 270, 90);
            // 右下
            path.AddArc(rect.Right - diameter - offset, rect.Bottom - diameter - offset, diameter, diameter, 0, 90);
            // 左下
            path.AddArc(rect.X, rect.Bottom - diameter - offset, diameter, diameter, 90, 90);

            // 连接四条直线
            path.CloseFigure();
            // 闭合路径中所有开放图形，并形成新图形
            //path.CloseAllFigures();
            return path;

            #endregion
        }
    }
}
