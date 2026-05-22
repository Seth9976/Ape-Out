using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public sealed class Vector3Parameter : ParameterOverride<Vector3>
	{
		// Token: 0x060002DB RID: 731 RVA: 0x0000E88C File Offset: 0x0000CA8C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Parameter()
		{
			Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Vector3Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr);
			Vector3Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100663510);
			Vector3Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100663511);
			Vector3Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100663512);
			Vector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr, 100663513);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000E90C File Offset: 0x0000CB0C
		[CallerCount(0)]
		public unsafe override void Interp(Vector3 from, Vector3 to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000E968 File Offset: 0x0000CB68
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector3Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector3Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445739, XrefRangeEnd = 445741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Parameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Parameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003B06 File Offset: 0x00001D06
		public Vector3Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector3_Vector3_Single_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3Parameter_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3Parameter_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
