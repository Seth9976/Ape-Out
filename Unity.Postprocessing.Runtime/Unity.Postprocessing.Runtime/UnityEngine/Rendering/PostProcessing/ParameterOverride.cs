using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003E RID: 62
	public class ParameterOverride : Object
	{
		// Token: 0x060002AD RID: 685 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterOverride()
		{
			Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ParameterOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr);
			ParameterOverride.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, "overrideState");
			ParameterOverride.NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_ParameterOverride_ParameterOverride_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663482);
			ParameterOverride.NativeMethodInfoPtr_GetHash_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663483);
			ParameterOverride.NativeMethodInfoPtr_GetValue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663484);
			ParameterOverride.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663485);
			ParameterOverride.NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663486);
			ParameterOverride.NativeMethodInfoPtr_SetValue_Internal_Abstract_Virtual_New_Void_ParameterOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663487);
			ParameterOverride.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663488);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000DB10 File Offset: 0x0000BD10
		[CallerCount(0)]
		public unsafe virtual void Interp(ParameterOverride from, ParameterOverride to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterOverride.NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_ParameterOverride_ParameterOverride_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000DB80 File Offset: 0x0000BD80
		[CallerCount(0)]
		public unsafe virtual int GetHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterOverride.NativeMethodInfoPtr_GetHash_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445719, XrefRangeEnd = 445723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterOverride.MethodInfoStoreGeneric_GetValue_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000DC04 File Offset: 0x0000BE04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterOverride.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000DC40 File Offset: 0x0000BE40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterOverride.NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		[CallerCount(0)]
		public unsafe virtual void SetValue(ParameterOverride parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterOverride.NativeMethodInfoPtr_SetValue_Internal_Abstract_Virtual_New_Void_ParameterOverride_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000DCCC File Offset: 0x0000BECC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterOverride()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterOverride.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003A73 File Offset: 0x00001C73
		public ParameterOverride(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000DD08 File Offset: 0x0000BF08
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00003A7C File Offset: 0x00001C7C
		public unsafe bool overrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterOverride.NativeFieldInfoPtr_overrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterOverride.NativeFieldInfoPtr_overrideState)) = value;
			}
		}

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_overrideState;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_ParameterOverride_ParameterOverride_Single_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Abstract_Virtual_New_Void_ParameterOverride_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000077 RID: 119
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_0<T>
		{
			// Token: 0x040004BC RID: 1212
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ParameterOverride.NativeMethodInfoPtr_GetValue_Public_T_0, Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
