USEFUL URL 我的MVC学习笔记
============================

## Ch1  

* JSON.NET  linq to json, json to xml
* DotNetOpenAuth 

* APP_Data用于存储想要读取写入的数据文件
* App_Start中主要存储配置逻辑
AuthConfig.cs 用来配置安全设置
BundleConfig.cs 用啦捆绑微小系统使用的捆绑。添加一些jQuery jQueryUI jQuery验证 Modernizr和css引用
FilterConfig.cs 过滤器
RouteCOnfig.cs 存放路由配置
WebApiConfig.cs 注册WebAPI 路由，设置其他WebAPAI配置设置

## Ch2 控制器 重点

用于相应用户输入，并且在响应时修改Model，提供View的输出数据。

ASP.NET 是一个基于事件的系统，他拥有一个基于控件和时间驱动的编程模型，为开发人员进行web开发提供了一个良好的组件化的GUI。当点击一个按钮时，Button控件做出相应，在服务器端引发时间。这种方法的好处在于他可以让开发人员在更高的抽象级别编写代码。很多工作都是在模拟这种组件化的时间驱动。然而本质上，点击Button时，浏览器像包含了页面上空间状态的服务器提交一个请求，服务器为了响应请求，需要重建空间的层次结构然后解释请求。没有必要因为单机一个UI级重建屏幕空间的层次结构。


## Ch3 视图 

* @ViewBag， @ViewData 是什么？
* XSS是什么


### Razor 语法

* Foreach循环
* 用()支持显示代码表达式
* 用@来转移@

* Html.Raw来用变量呈现html


* 布局
@RenderBody() 嵌入内容
@RenderSection() 


* _ViewStart
优先于同目录下的任何视图代码的执行

* 指定部分视图 

PartialViewResult,不渲染布局信息


## CH 4 Model



## CH 5 表单和辅助方法

### * post 和 get
POST	会把值放在httprequest主体中，重复提交会导致多条数据
GET		方法会把值附加在URL中，可以保存表单数据，Get是等幂操作，不会改变服务器的状态

### 辅助方法
* Html.BeginForm 
用来帮助form查找对应的view，BeginForm使用using语法糖来实现写入<form>用dispose来写入</form>

* Html.TextArea 
用来帮助写入Text内容，避免xss

* Html.ValidationSummary
写的太简单暂时没看懂

* Model 
Model模型传到Razor端，可以用dynamic类型，也可以使用强类型。强类型用 @model 来定义

* Html.EditorFor Html.TextBoxFor
EditorFor支持用属性注解来生成标签属性

* Html.HiddenFor 用来隐藏页面元素

* Html.Password
用来渲染密码字段。不保留提交值，显示掩码。

* Html.RadioButton  Html.CheckBox

* Html.ActionLink
用于渲染超链接，指向另一个控制器。可以像BeginForm一样在后台使用路由API来生成URL。

* Html.RouterLink
和ActionLink的用法差不多，只接收路由名称，不接受控制器名称和操作名称

* Url.Content
用于辅助寻找content未知，~表示根目录

* Html.Partial
用于将部分视图渲染成字符串
* Html.RenderPartial 
于Partial方法相似，但是不返回字符串，而是直接写入响应输出流。因此必须放到代码块中，而不能放在表达式中。因此具有更好的性能。

* Html.Action , Html.RenderAction
执行单独的控制器操作，并返回结果。RenderAction直接写入相应流。


## CH 6 数据注解和验证


## CH 7






