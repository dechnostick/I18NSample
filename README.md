I18NSample
==========

![](http://cdn-ak.f.st-hatena.com/images/fotolife/d/dechnostick/20140814/20140814001038.png)

カルチャを明示してフォームを開くと  

```cs
CultureInfo ci = new CultureInfo("ja-JP");
new Form2(ci).Show();
```

指定されたカルチャに応じたリソースが設定される。  

```cs
this.label1.Text = Properties.Resource.Hello;
this.label2.Text = Properties.Resource.ThankYou;
```

![](http://cdn-ak.f.st-hatena.com/images/fotolife/d/dechnostick/20140814/20140814001046.png)
