# 阅读和使用源码

## 解决方案说明

### Newbe.Mahua.Native

用于避免生成是 DllExport 任务出现冲突，因此将部分项目包含在该解决方案中。通常为 build.ps1 中调用。

### Newbe.Mahua.Pack

将需要打包为 nuget 包的项目包含在该解决方案中，这样就可以通过解决方案打包 nuget 包。通常为 build.ps1 中调用。

### Newbe.Mahua.Samples

包含了使用框架进行开发的样例程序。

### Newbe.Mahua

主要解决方案，包含了该框架的核心项目。

### Newbe.Mahua.VsExtensions

VS插件解决方案。若要加载该解决方案的内容，需要在安装VS时添加“VS扩展开发”相关的内容。

### Newbe.Mahua.Template

和其他的解决方案不同，其位于 src/Newbe.Mahua.Template 文件夹之下。

用于生成项目模板。

## 解决方案核心项目说明

### Newbe.Mahua

核心接口、常量、类的定义。作为所有项目的核心定义库。也是插件开发依赖的主要库之一。

### Newbe.Mahua.PluginLoader

对 Newbe.Mahua 进行实现的核心库，主要承担以下职责：

- 运行时判断装载不同平台下的实现类
- AppDomain 管理
- 便于不同平台开发的通用实现类
- 工具类

### Newbe.Mahua.Tools.Psake

编写用于插件开发的构建脚本及相关资源。

### 1)MahuaPlatforms

不同平台的实现类。一般包含有两个解决项目。

#### Newbe.Mahua.*

定义和信息和事件的接口和实现，一方面与 Newbe.Mahua.PluginLoader 交互，一方面与 Newbe.Mahua.*.Native 交互。

#### Newbe.Mahua.*.Native

通过 DLLExport 与非托管代码进行交互的项目。

### 2)Plugins

包含一个最简单的“嘤鹉学舌”插件，用于开发框架时进行测试和样例说明。

### 3)Tools

一些用于生成代码的工具。

### 4)Global

一些全局文件

### 5)Extensions

开发通用型扩展和特定平台扩展的内容。

## 编译

使用 cmd 或者 powershell 进入到 src 文件夹，运行以下命令进行编译：

```bash
./build.bat
```

编译过程可能出现两三次失败，可以重复运行直至通过为止。

小小的注意点：

- 需要网络正常，能够连接 nuget
- 如果出现 build 文件夹不存在相关的错误，可以手动在 src 文件夹下创建一个 build 空文件夹

## 打包

项目打包内容通过 nuget 的形式进行分发。

首先需要修改版本号。版本号信息保存在 src/Directory.Build.props 文件中。例如：

```xml
<Project>
  <PropertyGroup>
    <VersionPrefix>1.18.1</VersionPrefix>
    <VersionSuffix>dev01</VersionSuffix>
</Project>

```

其中 1.18.1 为正式版版本号， dev01 为当前的开发版本号。需要先了解[语义化版本号](https://semver.org/lang/zh-CN/)相关的知识，以便学习如何进行版本编号。

然后，可以通过以下命令进行打包：

```bash
./build.bat
```

打包完成后将会在 src/build 文件夹中生成当前版本的 nuget 包。其他项目，只要将这个文件夹设置为 nuget 源，便可以引用这些 nuget 包进行安装。

## 发布

若需要推送 nuget 包到 nuget.org 站点，需要设置密钥，并且使用以下命令便可以发送 nuget 包：

```bash
./build.bat NugetPushNuget
```

## 项目模板

当前的项目模板采用 netcore 中的模板机制，开发者可以[点击此处进行了解。](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)

当前项目对模板包的生成、测试和发布编写了脚本，可以通过以下脚本进行操作

| 脚本                     | 说明                  |
| ------------------------ | --------------------- |
| ./build.bat PackTemplate | 生成模板包            |
| ./build.bat TestTemplate | 安装并测试模板包      |
| ./build.bat PushTemplate | 发布模板包到 nuget 上 |