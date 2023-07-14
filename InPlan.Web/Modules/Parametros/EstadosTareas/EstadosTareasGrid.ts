import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EstadosTareasColumns, EstadosTareasRow, EstadosTareasService } from '../../ServerTypes/Parametros';
import { EstadosTareasDialog } from './EstadosTareasDialog';

@Decorators.registerClass('InPlan.Parametros.EstadosTareasGrid')
export class EstadosTareasGrid extends EntityGrid<EstadosTareasRow, any> {
    protected getColumnsKey() { return EstadosTareasColumns.columnsKey; }
    protected getDialogType() { return EstadosTareasDialog; }
    protected getRowDefinition() { return EstadosTareasRow; }
    protected getService() { return EstadosTareasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}