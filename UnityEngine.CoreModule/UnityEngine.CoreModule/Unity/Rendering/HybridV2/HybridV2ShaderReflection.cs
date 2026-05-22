using System;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Rendering.HybridV2
{
	// Token: 0x020001C9 RID: 457
	public class HybridV2ShaderReflection
	{
		// Token: 0x06001FC8 RID: 8136 RVA: 0x000107F6 File Offset: 0x0000E9F6
		public static IntPtr GetDOTSInstancingCbuffersPointer(global::UnityEngine.Shader shader, ref int cbufferCount)
		{
			return HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), ref cbufferCount);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00010809 File Offset: 0x0000EA09
		public static IntPtr GetDOTSInstancingPropertiesPointer(global::UnityEngine.Shader shader, ref int propertyCount)
		{
			return HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), ref propertyCount);
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0001081C File Offset: 0x0000EA1C
		public static uint GetDOTSReflectionVersionNumber()
		{
			return HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegateField();
		}

		// Token: 0x040019FE RID: 6654
		private static readonly HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegate GetDOTSInstancingCbuffersPointerDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingCbuffersPointer");

		// Token: 0x040019FF RID: 6655
		private static readonly HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegate GetDOTSInstancingPropertiesPointerDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingPropertiesPointer");

		// Token: 0x04001A00 RID: 6656
		private static readonly HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegate GetDOTSReflectionVersionNumberDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSReflectionVersionNumber");

		// Token: 0x02000AAC RID: 2732
		// (Invoke) Token: 0x060033BE RID: 13246
		private delegate IntPtr GetDOTSInstancingCbuffersPointerDelegate(IntPtr shader, IntPtr cbufferCount);

		// Token: 0x02000AAD RID: 2733
		// (Invoke) Token: 0x060033C0 RID: 13248
		private delegate IntPtr GetDOTSInstancingPropertiesPointerDelegate(IntPtr shader, IntPtr propertyCount);

		// Token: 0x02000AAE RID: 2734
		// (Invoke) Token: 0x060033C2 RID: 13250
		private delegate uint GetDOTSReflectionVersionNumberDelegate();
	}
}
