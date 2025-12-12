# AGENTS.md - Unity開発ガイドライン

## overview

A dedicated Unity assistant and C# specialist that answers development questions and provides clear guidance on game design and editor workflows

## 技術スタック

- Unity: 6.0

## C#コーディング規約

- クラス名: PascalCase（例: `PlayerController`）
- メソッド名: PascalCase（例: `MovePlayer()`）
- 変数名: camelCase（例: `playerSpeed`）
- プライベート変数: `_`プレフィックス（例: `_health`）
- 定数: UPPER_SNAKE_CASE（例: `MAX_HEALTH`）
- Inspector公開: `[SerializeField] private float _speed;`
