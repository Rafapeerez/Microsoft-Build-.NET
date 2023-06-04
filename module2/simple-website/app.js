'use strict';
const siwtcher = document.querySelector('.btn');

siwtcher.addEventListener('click', function(){
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');

    const className = document.body.className;
    if(className == 'light-theme'){
        this.textContent = "Dark";
    } else {
        this.textContent = "Light";
    }

    console.log('Current class name:' + className)
});