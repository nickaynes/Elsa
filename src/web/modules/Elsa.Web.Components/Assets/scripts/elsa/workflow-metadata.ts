namespace Elsa {
    export interface IWorkflowMetadata {
        id: string;
        parentId: string;
        name: string;
        description: string;
        customFields: any;
    }
}