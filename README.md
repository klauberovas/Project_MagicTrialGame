# 🧙‍♂️ Zkouška čaroděje – Textová hra v C#

## 🎮 O hře
**Zkouška čaroděje** je textová konzolová hra napsaná v C#, ve které se hráč ujme role mladého kouzelníka či čarodějky. Cílem hry je projít pěti magickými komnatami, v každé vyřešit hádanku, získat kouzlo a magický artefakt, a nakonec se utkat v rozhodujícím souboji s temným **Stínem** – bývalým učedníkem, který se obrátil ke zlu.

---

## 📜 Příběh
Po letech studia magie nastal den zkoušky Mistra. Vstupuješ do starobylé magické knihovny, kde na tebe čeká pět komnat s náročnými hádankami. Každá správná odpověď ti umožní získat **cenný artefakt** , jehož magická moc ti posílí tvou moc. V šesté a poslední místnosti tě čeká závěrečný **souboj s Stínem**, který kdysi býval nadějným učedníkem, ale jeho cesta vedla k temnotě.

---

## ⚙️ Pravidla a herní mechaniky

### 🏛️ Průchod místnostmi (1-5)
- **5 místností** s postupně se zvyšující obtížností hádanek
- **3 pokusy** na každou hádanku
- **Úspěšné řešení** → získání artefaktu s magickou mocí
- **Neúspěšné řešení** → žádná odměna, pokračování do další místnosti
- **Progresivní odměny**: Magická moc artefaktů se zvyšuje s obtížností hádanek
- **Progresivní bodování za správné odpovědi**:
  1. místnost: **2 body** (lehká hádanka)
  2. místnost: **3 body** (střední hádanka)
  3. místnost: **3 body** (střední hádanka)
  4. místnost: **4 body** (těžká hádanka)
  5. místnost: **5 bodů** (nejtěžší hádanka)
  - **Maximální možná magická moc**: 17 bodů

### ⚔️ Finální souboj se Stínem 
- **Stín**: 15 bodů magické moci + 100 životů
- **Hráč**: Nasbíraná magická moc (0-17 bodů) + 100 životů
- **Podmínka vítězství**: Vyšší magická moc než soupeř
- **Průběh souboje**:
  - Hráč začíná první
  - Souboj probíhá ve smyčce dokud jeden z bojovníků nemá 0 životů
  - Výsledek závisí na tom, kolik hádanek jste vyřešili správně
- **Scénáře vítězství**:
  - ✅ **15+ bodů**: Garantované vítězství (potřeba 4-5 správných odpovědí)
  - ⚠️ **10-14 bodů**: Těsná porážka (potřeba více správných odpovědí)
  - ❌ **0-9 bodů**: Jasná porážka

### 🎯 Strategie
Čím více hádanek správně vyřešíte, tím vyšší bude vaše magická moc a tím větší šanci na vítězství budete mít v souboji se Stínem! Pro jistotu vítězství potřebujete správně odpovědět na alespoň 4 z 5 hádanek.

---

## 🧭 Průběh hry
```text
1. Spuštění aplikace
2. Vstup do první místnosti → zobrazení hádanky
3. Zadávání odpovědí (max. 3 pokusy)
4. Vyhodnocení odpovědi → případná odměna (kartefakt + magická moc)
5. Přechod do další místnosti
6. Finální souboj 
7. Zobrazení výsledku a epilogu hry
```

## 🏗️ Architektura projektu
Hra využívá vícevrstvou architekturu s jasným oddělením zodpovědností mezi jednotlivými komponentami. Projekt je organizován do logických složek podle funkcionality.

Program.cs → Game.cs → GameEngine.cs → GameInitializer.cs + GameFlow.cs
                                    ↓
                              GameData (centrální stav)
                                    ↓
                    RoomManager → BattleEngine → GameUI

### 📁 Struktura projektu
1. #### 🎯 Core - Jádro aplikace
- **Program.cs** - Entry point aplikace, inicializuje hru a spouští hlavní smyčku
- **Game.cs** - Hlavní třída hry, která deleguje řízení na GameEngine
- **GameEngine.cs** - Centrální řídící jednotka koordinující inicializaci a průběh hry
- **GameFlow.cs** - Řídí sekvenci herních událostí (uvítání hráče, zpracování místností, finální souboj)
- **GameInitializer.cs** - Zodpovědný za inicializaci herních dat (hádanky, místnosti, nepřítele)                  

2. #### 📊 Models - Datové modely a logika
📂 Data
- **GameData.cs** - Centrální datový kontejner uchovávající celkový stav hry
- **RiddleData.cs** - Datový model pro uchovávání informací o hádankách
- **RoomData.cs** - Datová struktura reprezentující jednotlivé herní místnosti

📂 Entities
- **Entity.cs** - Základní abstraktní třída pro všechny herní entity
- **Player.cs** - Model hráče obsahující jeho statistiky, inventář a stav
- **Enemy.cs** - Model nepřátelských entit s jejich vlastnostmi a chováním

📂 Items
- **Artifact.cs** - Implementace speciálních artefaktů, které hráč může najít a použít

📂 Riddles
- **BaseRiddle.cs** - Základní třída pro všechny typy hádanek
- **Riddle.cs** - Konkrétní implementace standardních hádanek

📂 Enums
- **GameResults.cs** - Výčtové typy definující možné výsledky hry (výhra, prohra, atd.)

3. #### 🔧 Services - Pomocné služby 
📂 Battle
- **BattleEngine.cs** - Hlavní engine řídící bojové mechaniky mezi hráčem a nepřáteli

📂 DataLoading
- **RiddleLoader.cs** - Služba zodpovědná za načítání hádanek ze souborů nebo databáze
- **RoomFactory.cs** - Factory třída pro vytváření a konfiguraci herních místností

📂 Room
- **RoomManager.cs** - Správce místností řídící přechody a interakce v jednotlivých lokacích
- **RoomProcessor.cs** - Procesor zpracovávající logiku a události v místnostech

📂 Validation
- **PlayerValidator.cs** - Validační služba ověřující vstupní data od hráče
- **ValidationResult.cs** - Třída reprezentující výsledky validačních operací

4. #### 🎨 UI - Uživatelské rozhraní
- **GameUI.cs** - Uživatelské rozhraní zodpovědné za zobrazování textu, menu a interakci s hráčem

---
