# Koyuki Game

这是一个基于 Godot 引擎开发的简单游戏项目，包含两个小游戏：**Pong** 和 **Dino**。

## 项目结构

- **scenes/**: 存放游戏场景文件（如 `main_menu.tscn`, `node_2d.tscn`, `dino.tscn` 等）。
- **script/**: 存放 C# 脚本文件，用于实现游戏逻辑。
- **audio/**: 存放游戏中的音效和背景音乐。
- **images/**: 存放游戏所需的图片资源。
- **project.godot**: Godot 项目配置文件。

## 游戏介绍

### Pong
经典的双人对战乒乓球游戏，玩家通过控制左右球拍来击打乒乓球。

### Dino
一个简单的跑酷游戏，玩家控制角色跳跃躲避障碍物。

## 脚本说明

- `MainMenu.cs`: 主菜单逻辑，提供跳转到 Pong 和 Dino 游戏的按钮。
- `Node2d.cs`: Pong 游戏的主要逻辑，包括得分管理和游戏流程控制。
- `Koyuki.cs` 和 `KoyukiBall.cs`: 实现 Pong 游戏中的角色和球的物理行为。
- `Dino.cs`: Dino 游戏的核心逻辑，包括障碍物生成和碰撞检测。
- `DinoGameOver.cs`: Dino 游戏结束界面的逻辑。

## 如何运行

1. 安装 [Godot 引擎](https://godotengine.org/)（建议使用与项目兼容的版本）。
2. 打开 Godot，选择 `project.godot` 文件加载项目。
3. 点击运行按钮，即可启动游戏。

## 贡献指南

欢迎贡献代码或资源！请遵循以下步骤：
1. Fork 本仓库。
2. 创建新分支 (`git checkout -b feature/new-feature`)。
3. 提交更改 (`git commit -m 'Add new feature'`)。
4. 推送分支 (`git push origin feature/new-feature`)。
5. 提交 Pull Request。

## 许可证

本项目使用 MIT 许可证，详情请查看 LICENSE 文件。

--- 

如需进一步定制 README，请提供具体需求或项目描述。
