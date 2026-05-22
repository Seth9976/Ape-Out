using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public sealed class Vector2Parameter : ParameterOverride<Vector2>
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Parameter()
		{
			Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Vector2Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr);
			Vector2Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100663506);
			Vector2Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100663507);
			Vector2Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100663508);
			Vector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr, 100663509);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000E76C File Offset: 0x0000C96C
		[CallerCount(0)]
		public unsafe override void Interp(Vector2 from, Vector2 to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Vector2Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000E80C File Offset: 0x0000CA0C
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector2Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000E850 File Offset: 0x0000CA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445736, XrefRangeEnd = 445739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Parameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Parameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003AFD File Offset: 0x00001CFD
		public Vector2Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector2_Vector2_Single_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2Parameter_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2Parameter_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
