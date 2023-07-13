import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnicosProyectosForm {
    IdProyecto: IntegerEditor;
    IdTecnicos: IntegerEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class TecnicosProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.TecnicosProyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnicosProyectosForm.init)  {
            TecnicosProyectosForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(TecnicosProyectosForm, [
                'IdProyecto', w0,
                'IdTecnicos', w0,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}