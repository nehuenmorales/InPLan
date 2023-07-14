import { LookupEditor, StringEditor, TextAreaEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AmbientesProyectosForm {
    IdProyecto: LookupEditor;
    IdAmbiente: LookupEditor;
    ServidorWeb: StringEditor;
    InstaciaServidor: StringEditor;
    ServidorDatos: TextAreaEditor;
    NotasAdicionales: TextAreaEditor;
    Observaciones: TextAreaEditor;
    DocumentosRelacionados: MultipleImageUploadEditor;
}

export class AmbientesProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.AmbientesProyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AmbientesProyectosForm.init)  {
            AmbientesProyectosForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = MultipleImageUploadEditor;

            initFormType(AmbientesProyectosForm, [
                'IdProyecto', w0,
                'IdAmbiente', w0,
                'ServidorWeb', w1,
                'InstaciaServidor', w1,
                'ServidorDatos', w2,
                'NotasAdicionales', w2,
                'Observaciones', w2,
                'DocumentosRelacionados', w3
            ]);
        }
    }
}