import { IAppSettings } from 'src/model/infraestrutura/app';
import { IHeaderHttp } from 'src/model/infraestrutura/rest';
import Axios, { AxiosInstance, AxiosRequestConfig, AxiosError, AxiosResponse, AxiosStatic } from 'axios';
import axios from 'axios';

interface IApiClient {
    Get(url: string): any;
    Post(url: string, parametros: any): any;
}

class ApiClient implements IApiClient {
    private http: AxiosInstance;
    private readonly _api: IAppSettings;

    constructor(appSettings: IAppSettings) {
        this.http = axios.create({
            baseURL: appSettings.baseUrl
        });
        this._api = appSettings;
    }

    private _getHeaders(): IHeaderHttp {
        let header = {
            authorization: "Bearer " + this._api.token,
            contentType: "application/json"
        } as IHeaderHttp;
        return header;
    }

    Get(url: string) {
        var headers = this._getHeaders();
        var resultadoJson = this.http.get(this._api.baseUrl + url, { "headers": headers })
            .then(response => response.data);

        return resultadoJson;
    }

    Post(url: string, parametros: any) {
        var headers = this._getHeaders();
        var resultadoJson = this.http.post(this._api.baseUrl + url, parametros, { "headers": headers })
            .then(response => response.data);

        return resultadoJson;
    }
}

export { IApiClient, ApiClient };
