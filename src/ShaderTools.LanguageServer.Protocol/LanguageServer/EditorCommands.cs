//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using ShaderTools.LanguageServer.Protocol.MessageProtocol;

namespace ShaderTools.LanguageServer.Protocol.LanguageServer
{
    public class ClientEditorContext
    {
        public string CurrentFilePath { get; set; }

        public Position CursorPosition { get; set; }

        public Range SelectionRange { get; set; }

    }

    public class GetEditorContextRequest
    {
        public static readonly
            RequestType<GetEditorContextRequest, ClientEditorContext, object, object> Type =
                RequestType<GetEditorContextRequest, ClientEditorContext, object, object>.Create("editor/getEditorContext");
    }

    public enum EditorCommandResponse
    {
        Unsupported,
        OK
    }

    public class InsertTextRequest
    {
        public static readonly
            RequestType<InsertTextRequest, EditorCommandResponse, object, object> Type =
                RequestType<InsertTextRequest, EditorCommandResponse, object, object>.Create("editor/insertText");

        public string FilePath { get; set; }

        public string InsertText { get; set; }

        public Range InsertRange { get; set; }
    }

    public class SetSelectionRequest
    {
        public static readonly
            RequestType<SetSelectionRequest, EditorCommandResponse, object, object> Type =
                RequestType<SetSelectionRequest, EditorCommandResponse, object, object>.Create("editor/setSelection");

        public Range SelectionRange { get; set; }
    }

    public class SetCursorPositionRequest
    {
        public static readonly
            RequestType<SetCursorPositionRequest, EditorCommandResponse, object, object> Type =
                RequestType<SetCursorPositionRequest, EditorCommandResponse, object, object>.Create("editor/setCursorPosition");

        public Position CursorPosition { get; set; }
    }

    public class OpenFileRequest
    {
        public static readonly
            RequestType<string, EditorCommandResponse, object, object> Type =
                RequestType<string, EditorCommandResponse, object, object>.Create("editor/openFile");
    }

    public class CloseFileRequest
    {
        public static readonly
            RequestType<string, EditorCommandResponse, object, object> Type =
                RequestType<string, EditorCommandResponse, object, object>.Create("editor/closeFile");
    }

    public class ShowInformationMessageRequest
    {
        public static readonly
            RequestType<string, EditorCommandResponse, object, object> Type =
                RequestType<string, EditorCommandResponse, object, object>.Create("editor/showInformationMessage");
    }

    public class ShowWarningMessageRequest
    {
        public static readonly
            RequestType<string, EditorCommandResponse, object, object> Type =
                RequestType<string, EditorCommandResponse, object, object>.Create("editor/showWarningMessage");
    }

    public class ShowErrorMessageRequest
    {
        public static readonly
            RequestType<string, EditorCommandResponse, object, object> Type =
                RequestType<string, EditorCommandResponse, object, object>.Create("editor/showErrorMessage");
    }

    public class SetStatusBarMessageRequest
    {
        public static readonly
            RequestType<StatusBarMessageDetails, EditorCommandResponse, object, object> Type =
                RequestType<StatusBarMessageDetails, EditorCommandResponse, object, object>.Create("editor/setStatusBarMessage");
    }

    public class StatusBarMessageDetails
    {
        public string Message { get; set; }

        public int? Timeout { get; set; }
    }
}

