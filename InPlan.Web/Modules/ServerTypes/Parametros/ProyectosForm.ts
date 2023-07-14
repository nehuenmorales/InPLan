import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, DateEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProyectosForm {
    IdEmpresa: LookupEditor;
    IdArea: LookupEditor;
    NombreProyecto: StringEditor;
    DescripcionProyecto: TextAreaEditor;
    NroTicket: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
    FechaCarga: DateEditor;
    FechaInicio: DateEditor;
    FechaFin: DateEditor;
    DocumentosRelacionados: MultipleImageUploadEditor;
}

export class ProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.Proyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProyectosForm.init)  {
            ProyectosForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;
            var w4 = DateEditor;
            var w5 = MultipleImageUploadEditor;

            initFormType(ProyectosForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'NombreProyecto', w1,
                'DescripcionProyecto', w2,
                'NroTicket', w1,
                'Observaciones', w2,
                'Baja', w3,
                'FechaCarga', w4,
                'FechaInicio', w4,
                'FechaFin', w4,
                'DocumentosRelacionados', w5
            ]);
        }
    }
}