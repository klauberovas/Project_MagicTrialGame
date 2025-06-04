# 🧙‍♂️ Zkouška čaroděje – Textová hra v C#

## 🎮 O hře
**Zkouška čaroděje** je jednoduchá textová konzolová hra, ve které se hráč vžije do role mladého kouzelníka/čarodějky. Cílem hry je projít pěti magickými místnostmi, v každé správně vyřešit hádanku a na závěr se utkat v souboji s temným protivníkem – bývalým učedníkem známým jako **Stín**.

---

## 📜 Příběh
Po letech studia magie nastal den tvé závěrečné zkoušky. Vstupuješ do staré magické knihovny, kde na tebe čeká 5 komnat s hádankami. Každá správně vyřešená hádanka ti přinese nové **kouzlo** a **magický artefakt**. V poslední, šesté místnosti tě však čeká zkouška nejtěžší – **souboj se Stínem**, kdysi nadějným učedníkem, který magii použil ke zlým účelům.

---

## ⚙️ Pravidla a herní mechaniky

- 🔹 **5 místností s hádankou**
  - Každá hádanka = 3 pokusy na správnou odpověď.
  - Správná odpověď → hráč získá kouzlo + artefakt.
  - Špatná odpověď → hráč nezíská odměnu, ale pokračuje dál.

- 🔸 **Finální souboj ve 6. místnosti**
  - Pokud hráč získal **alespoň jedno kouzlo** → může Stína porazit.
  - Pokud hráč získal **všech 5 kouzel** → může Stína **zachránit**.
  - Pokud hráč nezískal žádné kouzlo → **prohraje**.

---

## 🧭 Průběh hry
```text
1. Spuštění hry
2. Vstup do první místnosti → hádanka
3. Odpověď hráče (max. 3 pokusy)
4. Odměna za správnou odpověď
5. Pokračování do dalších místností
6. Poslední místnost = finální souboj
7. Závěrečné vyhodnocení a epilog
```