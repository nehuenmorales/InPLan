import { LookupEditor, StringEditor, TextAreaEditor, DateEditor, MultipleImageUploadEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ImplementacionesForm {
    IdProyecto: LookupEditor;
    IdAmbienteProyecto: LookupEditor;
    IdTecnicoSolicitante: LookupEditor;
    IdTecnicoImplementa: LookupEditor;
    IdTipoImplementacion: LookupEditor;
    NroTicket: StringEditor;
    Descripcion: TextAreaEditor;
    FechaSolicitud: DateEditor;
    FechaPlanificada: DateEditor;
    FechaImplementacion: DateEditor;
    ConsideracionesPrevias: TextAreaEditor;
    ConsideracionesPosteriores: TextAreaEditor;
    NotasAdicionales: StringEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
    Observaciones: TextAreaEditor;
    UserId: IntegerEditor;
}

export class ImplementacionesForm extends PrefixedContext {
    static formKey = 'Implementacion.Implementaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ImplementacionesForm.init)  {
            ImplementacionesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = DateEditor;
            var w4 = MultipleImageUploadEditor;
            var w5 = IntegerEditor;

            initFormType(ImplementacionesForm, [
                'IdProyecto', w0,
                'IdAmbienteProyecto', w0,
                'IdTecnicoSolicitante', w0,
                'IdTecnicoImplementa', w0,
                'IdTipoImplementacion', w0,
                'NroTicket', w1,
                'Descripcion', w2,
                'FechaSolicitud', w3,
                'FechaPlanificada', w3,
                'FechaImplementacion', w3,
                'ConsideracionesPrevias', w2,
                'ConsideracionesPosteriores', w2,
                'NotasAdicionales', w1,
                'DocumentosAdicionales', w4,
                'Observaciones', w2,
                'UserId', w5
            ]);
        }
    }
}