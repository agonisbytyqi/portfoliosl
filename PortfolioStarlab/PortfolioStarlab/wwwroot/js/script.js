var x = document.getElementsByTagName("nav")[0];
function toggleNav() {
   if (x.className === "") {
      x.className = " openNav";
   }
   else {
      x.className = "";
   }
}
document.querySelector(".hamburger").addEventListener("click", toggleNav);

