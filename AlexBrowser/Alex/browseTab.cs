using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DD_HOST_Explorer
{
    class browseTab
    {
        // 概要:
        //     System.Windows.Forms.browseTab クラスの新しいインスタンスを初期化します。
        public browseTab();
        //
        // 概要:
        //     System.Windows.Forms.browseTab クラスの新しいインスタンスを初期化し、タブに使用するテキストを指定します。
        //
        // パラメータ:
        //   text:
        //     タブで使用するテキスト。
        public browseTab(string text);

        // 概要:
        //     このコントロールでは、このメンバは無効です。
        //
        // 戻り値:
        //     System.Windows.Forms.AnchorStyles 値です。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override AnchorStyles Anchor { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     既定値は false です。
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override bool AutoSize { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     常に System.Windows.Forms.AutoSizeMode.GrowOnly。
        [Browsable(false)]
        [Localizable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override AutoSizeMode AutoSizeMode { get; set; }
        //
        // 概要:
        //     System.Windows.Forms.browseTab の背景色を取得または設定します。
        //
        // 戻り値:
        //     System.Windows.Forms.browseTab の背景色を表す System.Drawing.Color。
        public override Color BackColor { get; set; }
        //
        // 概要:
        //     このコントロールでは、このメンバは無効です。
        //
        // 戻り値:
        //     System.Windows.Forms.DockStyle 値。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override DockStyle Dock { get; set; }
        //
        // 概要:
        //     このコントロールでは、このメンバは無効です。
        //
        // 戻り値:
        //     既定値は true です。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public bool Enabled { get; set; }
        //
        // 概要:
        //     このタブに表示されているイメージのインデックスを取得または設定します。
        //
        // 戻り値:
        //     タブに表示される System.Windows.Forms.TabControl.ImageList のイメージの 0 から始まるインデックス番号。既定値は
        //     -1 です。これはイメージがないことを示します。
        //
        // 例外:
        //   System.ArgumentException:
        //     System.Windows.Forms.browseTab.ImageIndex の値が -1 未満です。
        [RefreshProperties(RefreshProperties.Repaint)]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [TypeConverter(typeof(ImageIndexConverter))]
        [DefaultValue(-1)]
        public int ImageIndex { get; set; }
        //
        // 概要:
        //     関連付けられている System.Windows.Forms.TabControl の System.Windows.Forms.TabControl.ImageList
        //     で、イメージのキー アクセサを取得または設定します。
        //
        // 戻り値:
        //     イメージのキーを表す文字列。
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [DefaultValue("")]
        [RefreshProperties(RefreshProperties.Repaint)]
        [TypeConverter(typeof(ImageKeyConverter))]
        public string ImageKey { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     System.Drawing.Point。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public Point Location { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     System.Drawing.Size。
        [Browsable(false)]
        [DefaultValue(typeof(Size), "0, 0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Size MaximumSize { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     System.Drawing.Size。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override Size MinimumSize { get; set; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     System.Drawing.Size。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Size PreferredSize { get; }
        //
        // 概要:
        //     このコントロールでは、このプロパティは無効です。
        //
        // 戻り値:
        //     System.Int32。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TabIndex { get; set; }
        //
        // 概要:
        //     このコントロールでは、このメンバは無効です。
        //
        // 戻り値:
        //     既定値は true です。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public bool TabStop { get; set; }
        //
        // 概要:
        //     タブに表示されるテキストを取得または設定します。
        //
        // 戻り値:
        //     タブに表示されるテキスト。
        [Localizable(true)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text { get; set; }
        //
        // 概要:
        //     このタブのツールヒントのテキストを取得または設定します。
        //
        // 戻り値:
        //     このタブのツールヒントのテキスト。
        [DefaultValue("")]
        [Localizable(true)]
        public string ToolTipText { get; set; }
        //
        // 概要:
        //     visual スタイルが有効にされている場合に、System.Windows.Forms.browseTab の背景を現在の visual スタイルを使って描画するかどうかを示す値を取得または設定します。
        //
        // 戻り値:
        //     背景の描画に現在の visual スタイルを使用する場合は true。それ以外の場合は false。既定値は false です。
        [DefaultValue(false)]
        public bool UseVisualStyleBackColor { get; set; }
        //
        // 概要:
        //     このコントロールでは、このメンバは無効です。
        //
        // 戻り値:
        //     既定値は true です。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Visible { get; set; }

        // 概要:
        //     System.Windows.Forms.browseTab.AutoSize プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler AutoSizeChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.Dock プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler DockChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.Enabled プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler EnabledChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.Location プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler LocationChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.TabIndex プロパティの値が変更された場合に発生します。
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public event EventHandler TabIndexChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.TabStop プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler TabStopChanged;
        //
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler TextChanged;
        //
        // 概要:
        //     System.Windows.Forms.browseTab.Visible プロパティの値が変更された場合に発生します。
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler VisibleChanged;

        //
        // 戻り値:
        //     コントロールに割り当てられた System.Windows.Forms.Control.ControlCollection の新しいインスタンス。
        protected override Control.ControlCollection CreateControlsInstance();
        //
        // 概要:
        //     指定されたオブジェクトが格納されているタブ ページを取得します。
        //
        // パラメータ:
        //   comp:
        //     検索対象のオブジェクト。
        //
        // 戻り値:
        //     指定されたオブジェクトが格納されている System.Windows.Forms.browseTab。オブジェクトが見つからない場合は null。
        public static browseTab GetbrowseTabOfComponent(object comp);
        //
        // 概要:
        //     System.Windows.Forms.browseTab の System.Windows.Forms.Control.Enter イベントを発生させます。
        //
        // パラメータ:
        //   e:
        //     イベント データを格納している System.EventArgs。
        protected override void OnEnter(EventArgs e);
        //
        // 概要:
        //     System.Windows.Forms.browseTab の System.Windows.Forms.Control.Leave イベントを発生させます。
        //
        // パラメータ:
        //   e:
        //     イベント データを格納している System.EventArgs。
        protected override void OnLeave(EventArgs e);
        //
        // 概要:
        //     System.Windows.Forms.browseTab の背景を描画します。
        //
        // パラメータ:
        //   e:
        //     背景の描画に使用されるデータを格納している System.Windows.Forms.PaintEventArgs。
        protected override void OnPaintBackground(PaintEventArgs e);
        //
        // 概要:
        //     このメンバは System.Windows.Forms.Control.SetBoundsCore(System.Int32,System.Int32,System.Int32,System.Int32,System.Windows.Forms.BoundsSpecified)
        //     をオーバーライドします。
        //
        // パラメータ:
        //   x:
        //     コントロールの新しい System.Windows.Forms.Control.Left プロパティ値。
        //
        //   y:
        //     コントロールの新しい System.Windows.Forms.Control.Top プロパティ値。
        //
        //   width:
        //     コントロールの新しい System.Windows.Forms.Control.Width プロパティ値。
        //
        //   height:
        //     コントロールの新しい System.Windows.Forms.Control.Height プロパティ値。
        //
        //   specified:
        //     System.Windows.Forms.BoundsSpecified 値のビットごとの組み合わせ。
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
        //
        // 概要:
        //     System.Windows.Forms.browseTab.Text プロパティの値を格納している文字列を返します。
        //
        // 戻り値:
        //     System.Windows.Forms.browseTab.Text プロパティの値を格納している文字列。
        public override string ToString();

        // 概要:
        //     System.Windows.Forms.browseTab で使用されるコントロールのコレクションを格納します。
        [ComVisible(false)]
        public class browseTabControlCollection : Control.ControlCollection
        {
            // 概要:
            //     System.Windows.Forms.browseTab.browseTabControlCollection クラスの新しいインスタンスを初期化します。
            //
            // パラメータ:
            //   owner:
            //     コントロールのこのコレクションを格納している System.Windows.Forms.browseTab。
            public browseTabControlCollection(browseTab owner);

            // 概要:
            //     コントロールをコレクションに追加します。
            //
            // パラメータ:
            //   value:
            //     追加するコントロール。
            //
            // 例外:
            //   System.ArgumentException:
            //     指定されたコントロールが System.Windows.Forms.browseTab です。
            public override void Add(Control value);
        }
    }
}
