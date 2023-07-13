import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AmbientesProyectosForm {
    IdProyecto: IntegerEditor;
    IdAmbiente: IntegerEditor;
    ServidorDatos: StringEditor;
    InstaciaServidor: StringEditor;
    ServidorWeb: StringEditor;
    NotasAdicionales: StringEditor;
    DocumentosRelacionados: StringEditor;
    Observaciones: StringEditor;
}

export class AmbientesProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.AmbientesProyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AmbientesProyectosForm.init)  {
            AmbientesProyectosForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(AmbientesProyectosForm, [
                'IdProyecto', w0,
                'IdAmbiente', w0,
                'ServidorDatos', w1,
                'InstaciaServidor', w1,
                'ServidorWeb', w1,
                'NotasAdicionales', w1,
                'DocumentosRelacionados', w1,
                'Observaciones', w1
            ]);
        }
    }
}