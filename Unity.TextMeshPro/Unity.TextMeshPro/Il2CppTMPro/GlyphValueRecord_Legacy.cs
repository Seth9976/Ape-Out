using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	[StructLayout(2)]
	public struct GlyphValueRecord_Legacy
	{
		// Token: 0x0600030A RID: 778 RVA: 0x00013DEC File Offset: 0x00011FEC
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphValueRecord_Legacy()
		{
			Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphValueRecord_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr);
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_xPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xPlacement");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_yPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yPlacement");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xAdvance");
			GlyphValueRecord_Legacy.NativeFieldInfoPtr_yAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yAdvance");
			GlyphValueRecord_Legacy.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663626);
			GlyphValueRecord_Legacy.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663627);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00013E94 File Offset: 0x00012094
		[CallerCount(0)]
		public unsafe GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord_Legacy.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00013EC8 File Offset: 0x000120C8
		[CallerCount(0)]
		public unsafe static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord_Legacy.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000394F File Offset: 0x00001B4F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, ref this));
		}

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_xPlacement;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_yPlacement;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_yAdvance;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0;

		// Token: 0x0400021C RID: 540
		[FieldOffset(0)]
		public float xPlacement;

		// Token: 0x0400021D RID: 541
		[FieldOffset(4)]
		public float yPlacement;

		// Token: 0x0400021E RID: 542
		[FieldOffset(8)]
		public float xAdvance;

		// Token: 0x0400021F RID: 543
		[FieldOffset(12)]
		public float yAdvance;
	}
}
