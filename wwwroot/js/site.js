// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


//Array of mixins for Vue to load when instantiated
var mixinArray = [];


// 
Vue.component('Privacy', {
    props: {
        text: {
            type: String,
            default: 'PRIVACY',
            required: false,
            validator: function (value) {
                return value.toLowerCase().indexOf('foo') > -1;
            }
        }
    },
    template: `
    <h1 v-on:click="text = text.split('').reverse().join('')">{{text}}</h1> 
  `
});


if (document.querySelector("#privacy-vue") !== null) {

    /* eslint-disable no-new */
    new Vue({
        el: '#privacy-vue',
        data: {
            appLabel: 'foobar'
        },
        template: `
          <div>
            <privacy />
            <Privacy v-bind:text="appLabel"/>
          </div>
      `
    })
}