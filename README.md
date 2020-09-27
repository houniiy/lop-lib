# 完美联盟（Lop : League of perfect）
#### 我们是一帮专注于游戏圈的程序员，凭借多年的项目经验，利用近十年的时间，开发和维护了这套前后端框架；
#### 开发这套底层和框架的目标：减少重复劳动、高效稳定、快速启动新的项目、将已有项目中不稳定部分替换掉；
#### 高效稳定的底层和框架，会大大节约开发成本、缩短开发周期、提升开发效率、增强成员信心、提高成功概率。

## 基础类库
#### BCLib：基础C++程序库，多线程安全，支持跨平台；
#### CLLib：托管C++程序库，用于工具开发，仅Windows平台；
#### CSLib：基础CSharp程序库，基于 Mono 跨平台；
#### GELib：自研图形引擎程序库，基于DirectX开发，仅Windows平台；
#### LULib：基础Lua程序库，可以统一前后端逻辑开发；
#### MWLib：常用中间件程序库，多线程安全，支持跨平台；
#### SCLib：脚本与命令程序库，一些常用文档的脚本文件；
#### SFLib：服务器框架程序库，多线程安全，支持跨平台；
#### UDLib：基础Unity3D程序库，Unity开发专用；
#### UELib：基础UE4程序库，Unreal开发专用；
#### 依赖关系：
###### SCLib
###### LULib
###### CSLib -> UDLib
###### BCLib -> CLLib
###### BCLib -> GELib
###### BCLib -> MWLib
###### BCLib -> UELib
###### BCLib -> SFLib

## 导出类库
#### PBLib：使用Ext工具导出的Protobuf代码，支持众多语言，支持跨平台；
#### PELib：使用Lop工具导出的Protoext代码，支持C++,C#,Lua,GO等语言，支持跨平台；
#### LTLib：使用Lop工具导出的luatinkere代码，支持跨平台；
#### MSLib：使用Lop工具导出的消息及消息处理代码，支持前后端消息，支持跨平台；
#### DTLib：使用Lop工具导出的数据库任务及任务处理代码，支持跨平台；
#### 依赖关系：
###### PBLib -> PELib -> LTLib -> MSLib -> DTLib

## 扩展类库
#### SHLib：组内组外服务器抽象库
#### LSLib：组外服务器逻辑开发库
#### BSLib：组内服务器逻辑开发库
#### ESLib：战斗服务器逻辑与表现
#### 依赖关系：
###### SHLib -> LSLib
###### SHLib -> ESLib -> BSLib

## 支援方式
#### 有任何使用问题、BUG反馈、修改建议，请发邮件至：
#### 我们的邮箱：lop_dev@hotmail.com
#### 该邮箱为核心成员共同使用，对应模块的人会及时回复；

## 框架免费
#### 本套底层框架以及实例库，同时适用游戏软件开发和应用软件开发，大家可以免费下载使用；
#### 目前有多款线上游戏使用本套框架，稳定、并发、性能都得到验证，大家可以免费放心使用；
#### 能获取的源码已经上传，后续会逐步上传更多源码，对于未上传的源码，谢绝索取尽请配合。
#### 如果存在疑虑，建议您删除我们的框架，用其它同等框架替换。

## 寻找合作
#### 随着用户的增多，问题的咨询和功能扩展的需求也越来越多，团队成员经常熬夜来免费支援；
#### 考虑到长此以往，对团队成员健康不利，我们正在寻找有能力的公司或个人，进行合作开发；
#### 在保持框架独立发展、免费使用的基础上，会向合作方提供套件开发和配套服务的技术细节；
#### 同时考虑授权合作方，将开发的套件或配套的服务，再次向第三方公司或个人提供有偿服务；
#### 如有合作的意愿请与我们联系；

## 获取地址
#### GIT ：https://github.com/lop-dev/lop-lib.git
#### SVN ：https://github.com/lop-dev/lop-lib/trunk
#### 注：原OKBase获取地址，因为官方网站登录异常，不再维护，Github 虽然下载慢了一点，但是不会登陆异常。
