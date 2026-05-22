using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000012 RID: 18
	public static class TMP_Compatibility : Object
	{
		// Token: 0x0600010E RID: 270 RVA: 0x000029AC File Offset: 0x00000BAC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Compatibility()
		{
			Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Compatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr);
			TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr, 100663380);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000D378 File Offset: 0x0000B578
		[CallerCount(0)]
		public unsafe static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Compatibility.NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000029E5 File Offset: 0x00000BE5
		public TMP_Compatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0;

		// Token: 0x02000076 RID: 118
		[OriginalName("Unity.TextMeshPro.dll", "", "AnchorPositions")]
		public enum AnchorPositions
		{
			// Token: 0x04000B7D RID: 2941
			TopLeft,
			// Token: 0x04000B7E RID: 2942
			Top,
			// Token: 0x04000B7F RID: 2943
			TopRight,
			// Token: 0x04000B80 RID: 2944
			Left,
			// Token: 0x04000B81 RID: 2945
			Center,
			// Token: 0x04000B82 RID: 2946
			Right,
			// Token: 0x04000B83 RID: 2947
			BottomLeft,
			// Token: 0x04000B84 RID: 2948
			Bottom,
			// Token: 0x04000B85 RID: 2949
			BottomRight,
			// Token: 0x04000B86 RID: 2950
			BaseLine,
			// Token: 0x04000B87 RID: 2951
			None
		}
	}
}
