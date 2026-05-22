using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000043 RID: 67
	public class ABSPathDecoder : global::Il2CppSystem.Object
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00019514 File Offset: 0x00017714
		// Note: this type is marked as 'beforefieldinit'.
		static ABSPathDecoder()
		{
			Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "ABSPathDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr);
			ABSPathDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664129);
			ABSPathDecoder.NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664130);
			ABSPathDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr, 100664131);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00019580 File Offset: 0x00017780
		[CallerCount(0)]
		public unsafe virtual void FinalizePath(Path p, Il2CppStructArray<Vector3> wps, bool isClosedPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosedPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSPathDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000195F0 File Offset: 0x000177F0
		[CallerCount(0)]
		public unsafe virtual Vector3 GetPoint(float perc, Il2CppStructArray<Vector3> wps, Path p, Il2CppStructArray<ControlPoint> controlPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSPathDecoder.NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001967C File Offset: 0x0001787C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ABSPathDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSPathDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSPathDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000032AD File Offset: 0x000014AD
		public ABSPathDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Abstract_Virtual_New_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Abstract_Virtual_New_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
