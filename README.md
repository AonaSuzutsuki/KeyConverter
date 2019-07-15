# Mabinogi Key Converter
マビノギ向けに開発されたキー変換器です。  
キーボードの種類によってはCtrlやAltなどのキーが遠く、指が攣ることが多々あります。  
そんな時にこのソフトではそういったシステムキーを異なるキーに割り当てることができます。  
例えば、CtrlキーをAltキーに、AltキーをCtrlキーに転換することも可能です。  
これにより不快感の無いマビノギライフが実現できるでしょう。  

なお、マビノギ向けとしていますが、マビノギ検知を使用していない場合はWindows全体のキー置き換えソフトとして利用できます。  
レジストリの変換を利用しないので再起動も不要ですので起動後すぐにお使いいただけます。  

# 使い方
[MabinogiKeyConverter - Wiki](https://github.com/AonaSuzutsuki/MabinogiKeyConverter/wiki)に移動しました。  

# 注意
グローバルフックを用いてキーを操作するので予期せぬクラッシュなどによりキー操作が一切行えなくなる可能性があります。  
一応そういった致命的な不具合は無いように作っていますが、もしかすると起きる可能性が潰せていないのでもし発生しましたらご一報ください。  
また、BlackCipherに関しては入力されたキーを補足し、ソフト的にキーを押し直しているだけなので現段階では引っかかりませんが、将来的に禁止される可能性もあります。  
なお、**そういった事などによる損害に関しては一切責任を負いません**のでご容赦ください。  

# 必須項目
1. .Net Framework 4.7.1

# 動作確認
| OS | 動作状況 | 備考 |
|:---|:---|:---|
|Windows 7 x86 | 一応動作確認済み | 英語版で確認 |
|Windows 7 x64 | 不明 | - |
|Windows 8.x | 不明 | - |
|Windows 10 x86 | 不明 | - |
|Windows 10 x64 1903 | 正常動作 | - |

# Copyright
Copyright © Aona Suzutsuki 2018  

# Special thanks
1. [C#でSendInputを使う](https://gist.github.com/romichi/4971512)  
2. [Low-Level Keyboard Hook in C#](https://blogs.msdn.microsoft.com/toub/2006/05/03/low-level-keyboard-hook-in-c/)  
3. [Windows：SendInputで指定した"dwExtraInfo"をグローバルフック内で取得する](http://d.hatena.ne.jp/ken_2501jp/20130406/1365235955)  
4. [An ObservableDictionary<TKey, TValue>](https://gist.github.com/kzu/cfe3cb6e4fe3efea6d24)  

ReactiveProperty:   Copyright (c) 2018 neuecc, xin9le, okazuki  
Prism.Core:         Copyright (c) .NET Foundation