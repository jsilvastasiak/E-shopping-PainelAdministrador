
interface IUsuario {
    login: string;
    codigo: number;
}

class UsuarioApi implements IUsuario {
    login: string;
    codigo: number;
    constructor(login: string, codigo: number) {
        this.login = login;
        this.codigo = codigo;
    }
}

export { IUsuario };
export { UsuarioApi };