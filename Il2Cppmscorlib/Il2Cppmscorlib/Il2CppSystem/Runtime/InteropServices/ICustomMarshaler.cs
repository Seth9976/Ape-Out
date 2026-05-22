using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000456 RID: 1110
	public class ICustomMarshaler : Il2CppObjectBase
	{
		// Token: 0x06004416 RID: 17430 RVA: 0x0013A068 File Offset: 0x00138268
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomMarshaler()
		{
			Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ICustomMarshaler");
			ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100673197);
			ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100673198);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100673199);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100673200);
			ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100673201);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x0013A0F4 File Offset: 0x001382F4
		[CallerCount(0)]
		public unsafe virtual Object MarshalNativeToManaged(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x0013A14C File Offset: 0x0013834C
		[CallerCount(0)]
		public unsafe virtual IntPtr MarshalManagedToNative(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x0013A1A4 File Offset: 0x001383A4
		[CallerCount(0)]
		public unsafe virtual void CleanUpNativeData(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x0013A1F0 File Offset: 0x001383F0
		[CallerCount(0)]
		public unsafe virtual void CleanUpManagedData(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x0013A240 File Offset: 0x00138440
		[CallerCount(0)]
		public unsafe virtual int GetNativeDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00019FD1 File Offset: 0x000181D1
		public ICustomMarshaler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0;
	}
}
