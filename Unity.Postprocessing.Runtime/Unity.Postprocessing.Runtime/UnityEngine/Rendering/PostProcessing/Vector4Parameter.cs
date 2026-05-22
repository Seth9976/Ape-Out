using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public sealed class Vector4Parameter : ParameterOverride<Vector4>
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4Parameter()
		{
			Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Vector4Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr);
			Vector4Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100663514);
			Vector4Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100663515);
			Vector4Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100663516);
			Vector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100663517);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		[CallerCount(0)]
		public unsafe override void Interp(Vector4 from, Vector4 to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Parameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector4Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Vector4Parameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Parameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4Parameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000EB90 File Offset: 0x0000CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445741, XrefRangeEnd = 445743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4Parameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003B0F File Offset: 0x00001D0F
		public Vector4Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4Parameter_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4Parameter_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
