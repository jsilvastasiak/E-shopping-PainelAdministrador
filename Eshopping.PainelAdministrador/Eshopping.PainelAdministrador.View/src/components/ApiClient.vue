<script lang="ts">
    import { Component, Vue, Inject } from 'vue-property-decorator';
    import { IAppSettings } from '../../src/model/infraestrutura/app';
    import { IHeaderHttp } from '../../src/model/infraestrutura/rest';
    import Axios, { AxiosInstance, AxiosRequestConfig, AxiosError, AxiosResponse, AxiosStatic } from 'axios';

    @Component
    export default class ApiClient extends Vue {
        @Inject('api') private readonly api!: IAppSettings;        

        private http: AxiosInstance;

        constructor() {
            super();
            this.http = Axios.create({
                baseURL: this.api.baseUrl
            });
        }

        private _getHeaders(): IHeaderHttp {
            let header = {
                authorization: "Bearer " + this.api.token,
                contentType: "application/json"
            } as IHeaderHttp;
            return header;
        }

        public Get(url: string): any {
            var headers = this._getHeaders();
            var resultadoJson =  this.http.get(this.api.baseUrl + url, { "headers": headers })
                .then(response => response.data);

            return resultadoJson;
        }

        public Post(url: string, parametros: any): any {
            var headers = this._getHeaders();
            var resultadoJson = this.http.post(this.api.baseUrl + url, parametros, { "headers": headers })
                .then(response => response.data);

            return resultadoJson;
        }
    }
</script>