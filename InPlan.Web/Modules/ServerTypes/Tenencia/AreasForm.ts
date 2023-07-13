import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AreasForm {
    IdEmpresa: IntegerEditor;
    Descripcion: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class AreasForm extends PrefixedContext {
    static formKey = 'Tenencia.Areas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AreasForm.init)  {
            AreasForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(AreasForm, [
                'IdEmpresa', w0,
                'Descripcion', w1,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}