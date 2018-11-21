<template>
    <div>
        <h1>Counter</h1>
        <div v-for="add in address">
          <div> builing: {{add.buildingNum}}</div>
          <div>country :{{add.country.countryA}}</div>
        </div>
    </div>
</template>

<script>
  import { mapActions, mapState } from 'vuex';
  import axios from 'axios';
    export default {
      data () {
        return {
          autoCount: 0,
          address: {},
          address2: {},
        }
      },

      computed: {
        ...mapState({
          currentCount: state => state.counter
        })
      },

    methods: {

      async getBasicData() {
        var vm = this;
        var formData = new FormData(this.$refs.form);
        axios.get('/api/Addresses/all', formData)
          .then((response) => {

            try {
              vm.address = response.data.addresses;
              alert("welcome");

            }
            catch (e) {
              alert(e);
            }


          })
          .catch(function (error) {
            alert(error);
          })
      },


      async loadPage( ) {
        // ES2017 async/await syntax via babel-plugin-transform-async-to-generator
        // TypeScript can also transpile async/await down to ES5
      var  v="asdfasd"  ;

        try {
           
          let response = await this.$http.get(`/api/Addresses/all`)
          console.log(response.data.Addresses);
          //console.log(response.data.Addresses2);
          this.address = response.data.addresses;
          //this.address2 = response.data.Addresses2;
          var k = "abc";
          
        } catch (err) {
          window.alert(err)
          console.log(err)
        }
        // Old promise-based approach
        // this.$http
        //    .get('/api/SampleData/WeatherForecasts')
        //    .then(response => {
        //        console.log(response.data)
        //        this.forecasts = response.data
        //    })
        //    .catch((error) => console.log(error))*/
      }
    },

    async created() {
      //this.loadPage();
      this.getBasicData();

    }
    }
</script>

<style>
</style>
