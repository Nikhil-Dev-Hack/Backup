function javascript (date1, date2) {
    let oned = 24 * 60 * 60 * 1000;
    return Math.ceil((date2 - date1) / oned);
 }
 
 function javascript2(date1, date2) {
     return new Date(date2 - date1).getDate() - 1
 }
 
 function javascript4(date1, date2) {
   return Math.ceil((date2 - date1) / 8.64e7);
 }