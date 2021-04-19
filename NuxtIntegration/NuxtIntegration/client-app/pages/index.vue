<template>
  <div class="container">
    <div>
      <h1 class="title">
        NuxtIntegration
      </h1>
      <div class="links">
          <b-table sticky-header :items="books" head-variant="light" style="max-height: unset;"></b-table>
      </div>

    </div>
  </div>
</template>

<script>
  import config from '~/common/config.js'
  import axios from 'axios'

  export default {
    async asyncData({ query }) {
      const { data } = await axios.get(`${config.baseUrl}/books`)
      console.log(data)
      return {
        books: data
      }
    }
  }
</script>

<style>
  .container {
    margin: 0 auto;
    min-height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
  }

  .title {
    font-family: 'Quicksand', 'Source Sans Pro', -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif;
    display: block;
    font-weight: 300;
    font-size: 100px;
    color: #35495e;
    letter-spacing: 1px;
  }

  .subtitle {
    font-weight: 300;
    font-size: 42px;
    color: #526488;
    word-spacing: 5px;
    padding-bottom: 15px;
  }

  .links {
    padding-top: 15px;
    min-width: 960px;
  }
</style>
