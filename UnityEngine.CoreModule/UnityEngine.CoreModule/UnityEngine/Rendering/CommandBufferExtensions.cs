using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B6 RID: 694
	public static class CommandBufferExtensions
	{
		// Token: 0x060022BB RID: 8891 RVA: 0x00012909 File Offset: 0x00010B09
		public static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cmd), ref rt, fastMemoryFlags, residency, copyContents);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00012920 File Offset: 0x00010B20
		public static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cmd), ref rt, copyContents);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00012934 File Offset: 0x00010B34
		public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchIntoFastMemory(cmd, ref rid, fastMemoryFlags, residency, copyContents);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00012944 File Offset: 0x00010B44
		public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
		{
			CommandBufferExtensions.Internal_SwitchOutOfFastMemory(cmd, ref rid, copyContents);
		}

		// Token: 0x04001D94 RID: 7572
		private static readonly CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegate Internal_SwitchIntoFastMemoryDelegateField = IL2CPP.ResolveICall<CommandBufferExtensions.Internal_SwitchIntoFastMemoryDelegate>("UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchIntoFastMemory");

		// Token: 0x04001D95 RID: 7573
		private static readonly CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegate Internal_SwitchOutOfFastMemoryDelegateField = IL2CPP.ResolveICall<CommandBufferExtensions.Internal_SwitchOutOfFastMemoryDelegate>("UnityEngine.Rendering.CommandBufferExtensions::Internal_SwitchOutOfFastMemory");

		// Token: 0x02000BEF RID: 3055
		// (Invoke) Token: 0x06003636 RID: 13878
		private delegate void Internal_SwitchIntoFastMemoryDelegate(IntPtr cmd, IntPtr rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);

		// Token: 0x02000BF0 RID: 3056
		// (Invoke) Token: 0x06003638 RID: 13880
		private delegate void Internal_SwitchOutOfFastMemoryDelegate(IntPtr cmd, IntPtr rt, bool copyContents);
	}
}
