using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Windows.Forms;

namespace MaterialHaloSharp.Special_Controls
{
    public class fxLabel : Control
    {
        private BorderType _Border = BorderType.none;
        private Color _BorderColor = Color.FromArgb(0x40, 0x40, 0x40);
        private int _GlowAnimationSpeed = 100;
        private Color _GlowColor = Color.Black;
        private GlowTypes _GlowType = GlowTypes.GlowOnMouseEnter;
        private bool _Gradient;
        private Color _GradientColor = Color.Black;
        private int _GradientStrength = 50;
        private Bitmap _Image;
        private ImageAlignments _ImageAlign = ImageAlignments.Center;
        private int _RoundRadius = 3;
        private StringAlignment _TextAlign = StringAlignment.Center;
        private int _textglowintensity = 5;
        private Color _ThemeColor = Color.CornflowerBlue;
        private int _ThemeOpacity = 0xff;
        private int glowint;
        private System.Timers.Timer GlowTimer = new System.Timers.Timer();
        private System.Timers.Timer UnGlowTimer = new System.Timers.Timer();

        public fxLabel()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.Border = BorderType.none;
            this.BorderColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.FillColor = Color.CornflowerBlue;
            this.FillOpacity = 0xff;
            this.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GlowAnimationSpeed = 100;
            this.GlowColor = Color.DimGray;
            this.GlowItensity = 5;
            this.GlowType = GlowTypes.GlowOnMouseEnter;
            this.GradientStrength = 50;
            this.Image = null;
            this.ImageAlign = ImageAlignments.Center;
            base.Padding = new Padding(0, 0, 0, 0);
            this.RoundRadius = 3;
            base.Size = new Size(0x34, 0x12);
            base.TabIndex = 0;
            this.Text = "fxLabel";
            this.TextAlign = StringAlignment.Center;
            this.GlowTimer.Elapsed += new ElapsedEventHandler(this.GlowTimer_Elapsed);
            this.GlowTimer.Interval = this.GlowAnimationSpeed;
            this.UnGlowTimer.Elapsed += new ElapsedEventHandler(this.UnGlowTimer_Elapsed);
            this.UnGlowTimer.Interval = this.GlowTimer.Interval;
            base.MouseEnter += new EventHandler(this.GlowLabel_MouseEnter);
            base.MouseLeave += new EventHandler(this.GlowLabel_MouseLeave);
        }

        private void DrawBorders(Graphics Grr)
        {
            Pen p = new Pen(new SolidBrush(Color.FromArgb(this._ThemeOpacity, this._BorderColor)), 1f);
            switch (this._Border)
            {
                case BorderType.GradientFill:
                    this.Roundr(Grr, p, 0, 0, base.Width - 1, base.Height - 1, this._RoundRadius, true, true);
                    break;

                case BorderType.Fill:
                    this.Roundr(Grr, p, 0, 0, base.Width - 1, base.Height - 1, this._RoundRadius, true, false);
                    break;

                case BorderType.OnlyBorder:
                    this.Roundr(Grr, p, 0, 0, base.Width - 1, base.Height - 1, this._RoundRadius, false, false);
                    break;
            }
            p.Dispose();
        }

        private void DrawGlow(Graphics maingr)
        {
            switch (this._GlowType)
            {
                case GlowTypes.GlowOnMouseEnter:
                    this.DrawGlowText(this.Text, maingr, new SolidBrush(this.ForeColor), new SolidBrush(this._GlowColor), this.glowint);
                    return;

                case GlowTypes.AlwaysGlow:
                    this.DrawGlowText(this.Text, maingr, new SolidBrush(this.ForeColor), new SolidBrush(this._GlowColor), this._textglowintensity);
                    return;

                case GlowTypes.Pulse:
                    this.DrawGlowText(this.Text, maingr, new SolidBrush(this.ForeColor), new SolidBrush(this._GlowColor), this.glowint);
                    return;

                case GlowTypes.None:
                    this.DrawGlowText(this.Text, maingr, new SolidBrush(this.ForeColor), new SolidBrush(this._GlowColor), 0);
                    return;
            }
        }

        private void DrawGlowText(string iText, Graphics gr, SolidBrush BrushColor, SolidBrush GlowBrush, int INTENSITY = 3)
        {
            StringFormat format = new StringFormat
            {
                Alignment = this._TextAlign,
                LineAlignment = this._TextAlign
            };
            Rectangle layoutRect = new Rectangle(0, 0, base.Width, base.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddString(iText, this.Font.FontFamily, 0, this.Font.Size, layoutRect, format);
            for (int i = 1; i <= INTENSITY; i++)
            {
                Pen pen = new Pen(Color.FromArgb(30, GlowBrush.Color), (float)i)
                {
                    LineJoin = LineJoin.Round
                };
                gr.DrawPath(pen, path);
                pen.Dispose();
            }
            gr.FillPath(BrushColor, path);
            path.Dispose();
        }

        private void DrawImage(Graphics mainGr)
        {
            if (this._Image != null)
            {
                int left;
                int num2;
                Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
                switch (this._ImageAlign)
                {
                    case ImageAlignments.TopRight:
                        left = ((rectangle.Right - this._Image.Width) - base.Padding.Right) - 1;
                        num2 = (rectangle.Top + base.Padding.Top) + 1;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.MiddleRight:
                        left = ((rectangle.Right - this._Image.Width) - base.Padding.Right) - 1;
                        num2 = (base.Height / 2) - (this._Image.Height / 2);
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.BottomRight:
                        left = ((rectangle.Right - this._Image.Width) - base.Padding.Right) - 1;
                        num2 = ((rectangle.Bottom - this._Image.Height) - base.Padding.Bottom) - 1;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        break;

                    case ImageAlignments.CenterTop:
                        left = (base.Width / 2) - (this._Image.Width / 2);
                        num2 = ((this._Image.Height / 2) - (this._Image.Height / 2)) + base.Padding.Top;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.Center:
                        left = (base.Width / 2) - (this._Image.Width / 2);
                        num2 = (base.Height / 2) - (this._Image.Height / 2);
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.CenterBottom:
                        left = (base.Width / 2) - (this._Image.Width / 2);
                        num2 = ((rectangle.Bottom - this._Image.Height) - base.Padding.Bottom) - 1;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.TopLeft:
                        left = base.Padding.Left + 1;
                        num2 = base.Padding.Top + 1;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.TopMiddle:
                        left = base.Padding.Left;
                        num2 = (base.Height / 2) - (this._Image.Height / 2);
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    case ImageAlignments.BottomLeft:
                        left = (rectangle.Left + base.Padding.Left) + 1;
                        num2 = ((rectangle.Bottom - this._Image.Height) - base.Padding.Bottom) - 1;
                        mainGr.DrawImage(this._Image, left, num2, this._Image.Size.Width, this._Image.Size.Height);
                        return;

                    default:
                        return;
                }
            }
        }

        private void GlowLabel_MouseEnter(object sender, EventArgs e)
        {
            this.GlowTimer.Start();
            this.UnGlowTimer.Stop();
            base.Invalidate();
        }

        private void GlowLabel_MouseLeave(object sender, EventArgs e)
        {
            this.UnGlowTimer.Start();
            base.Invalidate();
        }

        private void GlowLabel_PaddingChanged(object sender, EventArgs e)
        {
            base.Invalidate();
        }

        private void GlowLabel_TextChanged(object sender, EventArgs e)
        {
            base.Invalidate();
        }

        private void GlowTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch (this._GlowType)
            {
                case GlowTypes.GlowOnMouseEnter:
                    if (this.glowint != 5)
                    {
                        this.glowint++;
                        break;
                    }
                    this.GlowTimer.Stop();
                    break;

                case GlowTypes.Pulse:
                    if (this.glowint < 5)
                    {
                        this.glowint++;
                        break;
                    }
                    this.GlowTimer.Stop();
                    this.UnGlowTimer.Start();
                    break;
            }
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grr = e.Graphics;
            grr.InterpolationMode = InterpolationMode.NearestNeighbor;
            grr.SmoothingMode = SmoothingMode.AntiAlias;
            this.DrawBorders(grr);
            this.DrawGlow(grr);
            this.DrawImage(grr);
        }

        private void Roundr(Graphics g, Pen p, int x, int y, int width, int height, int radius, bool FILL = false, bool Grad = false)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(x + radius, y, (x + width) - radius, y);
            path.AddArc((x + width) - radius, y, radius, radius, 270f, 90f);
            path.AddLine((int)(x + width), (int)(y + radius), (int)(x + width), (int)((y + height) - radius));
            path.AddArc((x + width) - radius, (y + height) - radius, radius, radius, 0f, 90f);
            path.AddLine((int)((x + width) - radius), (int)(y + height), (int)(x + radius), (int)(y + height));
            path.AddArc(x, (y + height) - radius, radius, radius, 90f, 90f);
            path.AddLine(x, (y + height) - radius, x, y + radius);
            path.AddArc(x, y, radius, radius, 180f, 90f);
            path.CloseFigure();
            g.DrawPath(p, path);
            if (FILL)
            {
                SolidBrush brush = null;
                brush = new SolidBrush(p.Color);
                g.FillPath(brush, path);
            }
            if (Grad)
            {
                LinearGradientBrush brush2 = new LinearGradientBrush(new RectangleF(0f, 0f, (float)base.Width, (float)(base.Height + this._GradientStrength)), Color.FromArgb(this._ThemeOpacity, this._ThemeColor), Color.FromArgb(this._ThemeOpacity, this._GradientColor), LinearGradientMode.Vertical);
                g.FillPath(brush2, path);
            }
            path.Dispose();
        }

        private void UnGlowTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch (this._GlowType)
            {
                case GlowTypes.GlowOnMouseEnter:
                    if (this.glowint != 0)
                    {
                        this.glowint--;
                        this.GlowTimer.Stop();
                        break;
                    }
                    this.glowint = 0;
                    this.UnGlowTimer.Stop();
                    break;

                case GlowTypes.Pulse:
                    if (this.glowint > 1)
                    {
                        this.glowint--;
                        this.GlowTimer.Stop();
                        break;
                    }
                    this.glowint = 1;
                    this.UnGlowTimer.Stop();
                    this.GlowTimer.Start();
                    break;
            }
            base.Invalidate();
        }

        public BorderType Border
        {
            get
            {
                return this._Border;
            }
            set
            {
                this._Border = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public Color BorderColor
        {
            get
            {
                return this._BorderColor;
            }
            set
            {
                this._BorderColor = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public Color FillColor
        {
            get
            {
                return this._ThemeColor;
            }
            set
            {
                this._ThemeColor = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public int FillOpacity
        {
            get
            {
                return this._ThemeOpacity;
            }
            set
            {
                this._ThemeOpacity = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public int GlowAnimationSpeed
        {
            get
            {
                this.GlowTimer.Interval = this._GlowAnimationSpeed;
                this.UnGlowTimer.Interval = this._GlowAnimationSpeed;
                return this._GlowAnimationSpeed;
            }
            set
            {
                this._GlowAnimationSpeed = value;
                this.GlowTimer.Interval = this._GlowAnimationSpeed;
                this.UnGlowTimer.Interval = this._GlowAnimationSpeed;
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public Color GlowColor
        {
            get
            {
                return this._GlowColor;
            }
            set
            {
                this._GlowColor = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public int GlowItensity
        {
            get
            {
                return this._textglowintensity;
            }
            set
            {
                this._textglowintensity = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public GlowTypes GlowType
        {
            get
            {
                return this._GlowType;
            }
            set
            {
                this._GlowType = value;
                if (this._GlowType == GlowTypes.Pulse)
                {
                    this.GlowTimer.Start();
                }
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public int GradientStrength
        {
            get
            {
                return this._GradientStrength;
            }
            set
            {
                this._GradientStrength = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public Bitmap Image
        {
            get
            {
                return this._Image;
            }
            set
            {
                this._Image = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public ImageAlignments ImageAlign
        {
            get
            {
                return this._ImageAlign;
            }
            set
            {
                this._ImageAlign = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public int RoundRadius
        {
            get
            {
                return this._RoundRadius;
            }
            set
            {
                this._RoundRadius = value;
                base.Invalidate();
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public StringAlignment TextAlign
        {
            get
            {
                return this._TextAlign;
            }
            set
            {
                this._TextAlign = value;
                if (base.DesignMode)
                {
                    base.Invalidate();
                }
            }
        }

        public enum BorderType
        {
            GradientFill,
            Fill,
            OnlyBorder,
            none
        }

        public enum GlowTypes
        {
            AlwaysGlow = 2,
            GlowOnMouseEnter = 1,
            None = 4,
            Pulse = 3
        }

        public enum ImageAlignments
        {
            TopRight,
            MiddleRight,
            BottomRight,
            CenterTop,
            Center,
            CenterBottom,
            TopLeft,
            TopMiddle,
            BottomLeft
        }
    }
}

