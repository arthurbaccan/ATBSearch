<?php

//transforma valor 1 em true, e 0 em false
function transformaGramEmString($numero) {
    if ($numero==1) {
        return "✅";
    } else {
        return "❌";
    }
}

//transforma valores de 1 a 15 nos respectivos tipos do antibiótico
function transforamTipoEmString($numero) {
    switch ($numero) {
        case 1: return "Macrolídeos";

        case 2: return "Penicilinas";

        case 3: return "Cefalosporinas";

        case 4: return "Carbapenêmicos";

        case 5: return "Aminoglicosídeos";

        case 6: return "Quinolonas";

        case 7: return "Anfenicóis";

        case 8: return "Sulfonamidas";

        case 9: return "Glicopeptídeos";

        case 10: return "Nitroimdazólicos";

        case 11: return "Licosamidas";

        case 12: return "Polimixinas";

        case 13: return "Oxazolidinona";

        case 14: return "Glicilciclina";

        case 15: return "Antituberculosos";
    }
}

function transformaMorfologiaEmString($numero) {
    switch ($numero) {
        case 1: return "Cocos";

        case 2: return "Bacilos";

        case 3: return "Cocos e Bacilos";
    }
}



?>