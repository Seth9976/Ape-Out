using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	[StructLayout(2)]
	public struct ControlPoint
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x000193C8 File Offset: 0x000175C8
		// Note: this type is marked as 'beforefieldinit'.
		static ControlPoint()
		{
			Il2CppClassPointerStore<ControlPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "ControlPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr);
			ControlPoint.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, "a");
			ControlPoint.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, "b");
			ControlPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, 100664126);
			ControlPoint.NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, 100664127);
			ControlPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, 100664128);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001945C File Offset: 0x0001765C
		[CallerCount(0)]
		public unsafe ControlPoint(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001949C File Offset: 0x0001769C
		[CallerCount(0)]
		public unsafe static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPoint.NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000194E8 File Offset: 0x000176E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123881, XrefRangeEnd = 123917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000329B File Offset: 0x0000149B
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400035D RID: 861
		[FieldOffset(0)]
		public Vector3 a;

		// Token: 0x0400035E RID: 862
		[FieldOffset(12)]
		public Vector3 b;
	}
}
