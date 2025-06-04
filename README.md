# 🧙‍♂️ Zkouška čaroděje – Textová hra v C#

## 🎮 O hře
**Zkouška čaroděje** je textová konzolová hra napsaná v C#, ve které se hráč ujme role mladého kouzelníka či čarodějky. Cílem hry je projít pěti magickými komnatami, v každé vyřešit hádanku, získat kouzlo a magický artefakt, a nakonec se utkat v rozhodujícím souboji s temným **Stínem** – bývalým učedníkem, který se obrátil ke zlu.

---

## 📜 Příběh
Po letech studia magie nastal den zkoušky Mistra. Vstupuješ do starobylé magické knihovny, kde na tebe čeká pět komnat s náročnými hádankami. Každá správná odpověď ti umožní osvojit si nové **kouzlo** a získat **cenný artefakt**. V šesté a poslední místnosti tě čeká závěrečný **souboj s Stínem**, který kdysi býval nadějným učedníkem, ale jeho cesta vedla k temnotě.

---

## ⚙️ Pravidla a herní mechaniky

- 🔹 **Komnaty s hádankami (5 místností)**
  - Každá hádanka = 3 pokusy na správnou odpověď.
  - Správná odpověď → hráč získá kouzlo + artefakt.
  - Špatná odpověď → hráč nezíská odměnu, ale pokračuje dál.

- 🔸 **Finální souboj (6. místnost)**
  - Pokud hráč získal **alespoň jedno kouzlo** → může Stína porazit.
  - Pokud hráč získal **všech 5 kouzel** → může Stína **zachránit**.
  - Pokud hráč nezískal žádné kouzlo → **prohraje**.

---

## 🧭 Průběh hry
```text
1. Spuštění aplikace
2. Vstup do první místnosti → zobrazení hádanky
3. Zadávání odpovědí (max. 3 pokusy)
4. Vyhodnocení odpovědi → případná odměna (kouzlo + artefakt)
5. Přechod do další místnosti
6. Finální souboj v šesté místnosti
7. Zobrazení výsledku a epilogu hry
```