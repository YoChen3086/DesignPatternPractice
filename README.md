# 大話設計模式練習
# Design pattern practice

- ### Chapter1:
    ### 程式碼無錯就是優? --> 簡單工廠模式(Simple factory)

- ### Chapter2:
    ### 商場促銷 --> 策略模式(Strategy)

- ### Chapter3:
    ### 拍攝UFO --> 單一職責原則(Single responsibility principle)
    ###### 就一個類別而言，應該只有一個引起他變化的原因。
    ###### *沒有範例程式拉!!或者可以寫一下俄羅斯方塊，但最後再來寫寫看*

- ### Chapter4:
    ### 升學求職兩不誤 --> 開放封閉原則(The Open-Closed Principle)
    ###### 軟體實體(類別、模組、函數等等)應該可以擴展，但是不可修改。

- ### Chapter5:
    ### 會修電腦不會修收音機? --> 依賴倒轉原則
    ###### A. 高層模組不應該依賴低層模組。兩個都應該依賴抽象。
    ###### B. 抽象不應該依賴細節。細節應該依賴抽象。
    ### Liskov替換原則
    ###### 子類型必須能夠替換掉他們的父類型。

- ### Chapter6:
    ### 穿什麼有這麼重要? --> 裝飾模式(Decorator)
    ###### 動態地給一個物件加入一些額外的職責，就增加功能來說，裝飾模式比產生子類別更為靈活。

- ### Chapter7:
    ### 為他人做嫁衣? --> 代理模式(Proxy)
    ###### 為其他物件提供一種代理以控制對這個物件的存取。

- ### Chapter8:
    ### 南丁格爾依然在人間? --> 工廠方法模式(Factory method)
    ###### 定義一個用於建立物件的介面，讓子類決定實體化哪一個類別。工廠方法使一個類別的實例化延遲到其子類別。
    
- ### Chapter9:
    ### 履歷影印 --> 原型模式(Prototype)
    ###### 用原型實例指定建立物件的種類，並且透過拷貝這些原形建立新的物件。

- ### Chapter10:
    ### 考題抄錯會做也白搭 --> 範本方法模式(Template method)
    ###### 定義一個操作中的演算法的骨架，而將依些步驟延遲到子類別中。範本方法使得子類別可以不改變一個演算法的結構即可重定義該演算法的某些特定步驟。
    
- ### Chapter11:
    ### 無熟人難辦事 --> 迪米特法則(Lod,Law of Demeter)
    ###### 又叫最少知識原則
    ###### 如果兩個類別不必彼此直接通信，那麼這兩個類別就不應當發生直接的相互作用。如果其中一個類別淤要調用另一個類別的某一個方法的話，可以透過第三者轉發這個調用。

- ### Chapter12:
    ### 多頭市場股票還會虧錢? --> 外觀模式(Facade)
    ###### 為子系統中的一組介面，提供一個一致的介面，此模式定義了一個高層介面，這個介面使得這一子系統更加容易使用。

- ### Chapter13:
    ### 好菜每回味不同 --> 建造者模式(Builder)
    ###### 將一個複雜物件的建構與他的表示分離，使得同樣的建造過程可以建立不同的表示。

- ### Chapter14:
    ### 老闆回來，我不知道 --> 觀察者模式(Observer)或 發佈/訂閱模式 (Publish/Subscribe)
    ###### 定義了一種一對多的依賴關係，讓多個觀察者物件同時監聽某一個主題物件。這個主題物件在狀態發生變化時，會通知所有觀察者物件，使他們能夠自動更新自己。

- ### Chapter15:
    ### 就不能不換嗎? --> 抽象工廠模式(Abstract Factory)
    ###### 提供一個建立一系列相關或相互依賴物件的介面，而無須指定他們具體的類別。
    ###### 15.9 dotnet core 設定檔讀取方式需要再查查
    
- ### Chapter16:
    ### 無盡加班何時休 --> 狀態模式(State)
    ###### 當一個物件的內在狀態改變時允許改變其行為，這個物件看起來像是改變了其類別。
    
- ### Chapter17:
    ### 在NBA我需要翻譯 --> 轉接器模式(Adapter)
    ###### 將一個類別的介面轉換成客戶希望的另外一個介面。Adapter模式使得原本由於介面不相容而不能一起工作的那些類別可以一起工作。
    
- ### Chapter18:
    ### 如果再回到從前 --> 備忘錄模式(Memento)
    ###### 在不破壞封裝性的前提下，捕獲一個物件的內部狀態，並在該物件之外保存這個狀態。這樣以後就可將該物件恢復到原先保存的狀態。