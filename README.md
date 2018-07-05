# Ganko

> Ganko is a gank.io client demo.
>
> Actually it is a curriculum design for a course called C# programming design. 
>
> Ganko是一个gank.io的客户端demo。

---

###Application Demonstration - 项目展示

**Login Form** - 登录界面

![pic1](http://ouq4wp7r4.bkt.clouddn.com/GankoPic1.png)



**Sign Up Form** - 注册界面

![pic2](http://ouq4wp7r4.bkt.clouddn.com/GankoPic2.png)



**Main Form** - 主界面

![pic3](http://ouq4wp7r4.bkt.clouddn.com/GankoPic3.png)



**User Information Page** - 用户信息界面

![pic4](http://ouq4wp7r4.bkt.clouddn.com/GankoPic4.png)



**Settings Page** - 设置界面

![pic5](http://ouq4wp7r4.bkt.clouddn.com/GankoPic5.png)



**Change Theme Demo** - 主题更改

![pic6](http://ouq4wp7r4.bkt.clouddn.com/GankoPic6.png)



### Application Introduction & Structure - 项目简介以及结构

该项目采用了MySQL作为开发环境数据库，使用JSON.Net解析JSON，将FireFox（火狐）浏览器内核Gecko作为WebBrowser的浏览器内核，项目包含Commons和Resource文件夹，Commons用于将一些基本功能模块化，目前具有注册登录模块、数据库操作模块、API处理模块、安全处理模块、实体类库，而Resource用于存储图片等静态内容。

**项目结构**

![pic7](http://ouq4wp7r4.bkt.clouddn.com/GankoPic7.png)



**类图**

![classGraph](http://ouq4wp7r4.bkt.clouddn.com/GankoClassDiagram.jpg)

**APIProcessor**

![APIProcessor](http://ouq4wp7r4.bkt.clouddn.com/APIProcessor.png)

**DBHelper**

![DBHelper](http://ouq4wp7r4.bkt.clouddn.com/DBHelper.png)

**Models**

![Models](http://ouq4wp7r4.bkt.clouddn.com/Models.png)

**ResultModels**

![Result Models](http://ouq4wp7r4.bkt.clouddn.com/ResultModel.png)

**SecurityProcessor**

![SecurityProcessor](http://ouq4wp7r4.bkt.clouddn.com/SecurityProcessor.png)

### To do List

- [x] 登录/注册功能
- [x] 按类别获取内容功能
- [ ] 按日期获取内容功能
- [ ] 本地收藏功能