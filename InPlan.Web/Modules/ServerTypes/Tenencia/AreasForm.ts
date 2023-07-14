import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AreasForm {
    IdEmpresa: LookupEditor;
    Descripcion: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class AreasForm extends PrefixedContext {
    static formKey = 'Tenencia.Areas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AreasForm.init)  {
            AreasForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(AreasForm, [
                'IdEmpresa', w0,
                'Descripcion', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}