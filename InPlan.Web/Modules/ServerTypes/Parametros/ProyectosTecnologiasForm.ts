import { IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProyectosTecnologiasForm {
    IdProyecto: IntegerEditor;
    IdTecnologia: IntegerEditor;
}

export class ProyectosTecnologiasForm extends PrefixedContext {
    static formKey = 'Parametros.ProyectosTecnologias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProyectosTecnologiasForm.init)  {
            ProyectosTecnologiasForm.init = true;

            var w0 = IntegerEditor;

            initFormType(ProyectosTecnologiasForm, [
                'IdProyecto', w0,
                'IdTecnologia', w0
            ]);
        }
    }
}