import { LookupEditor, IntegerEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnicosProyectosForm {
    IdProyecto: LookupEditor;
    IdTecnico: IntegerEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class TecnicosProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.TecnicosProyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnicosProyectosForm.init)  {
            TecnicosProyectosForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(TecnicosProyectosForm, [
                'IdProyecto', w0,
                'IdTecnico', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}