<template>
    <div>
        <h1>Counter</h1>
        <div v-for="add in address">
         builing: {{add.buildingNum}}
        </div>
    </div>
</template>

<script>
    import { mapActions, mapState } from 'vuex'

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
      async loadPage( ) {
        // ES2017 async/await syntax via babel-plugin-transform-async-to-generator
        // TypeScript can also transpile async/await down to ES5
      var  v="asdfasd"  ;

        try {
           
          let response = await this.$http.get(`/api/Addresses`)
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
      this.loadPage()
    }
    }
</script>

<style>
</style>
