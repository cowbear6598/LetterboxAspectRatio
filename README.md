## 黑邊自適應

- CameraLetterbox: 更改主攝影機的 Rect 來達成強制所解析度以及加上黑邊處理。
- CanvasResolutionHandler: 更改 Canvas Scaler 的 Scale With Screen Size，計算目前解析度與設定的解析度的比例來調整依據 Width 還是 Height。 
- 兩個可分開使用，尤其是 UI，因為黑邊的功能就目前遊戲來說真的比較少看到，更多是依據解析度調整好 UI 的位置
