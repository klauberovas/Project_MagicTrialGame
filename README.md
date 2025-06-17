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
  - 1. místnost: **2 body** (lehká hádanka)
  - 2. místnost: **3 body** (střední hádanka)
  - 3. místnost: **3 body** (střední hádanka)
  - 4. místnost: **4 body** (těžká hádanka)
  - 5. místnost: **5 bodů** (nejtěžší hádanka)
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