using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000EC RID: 236
	public class IControllerElementIdentifierCommon_Internal : Il2CppObjectBase
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x0008B158 File Offset: 0x00089358
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerElementIdentifierCommon_Internal()
		{
			Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerElementIdentifierCommon_Internal");
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669238);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669239);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_positiveName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669240);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_negativeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669241);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669242);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669243);
			IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_editorElementTypeOverride_Public_Abstract_Virtual_New_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementIdentifierCommon_Internal>.NativeClassPtr, 100669244);
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0008B20C File Offset: 0x0008940C
		public unsafe virtual int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0008B254 File Offset: 0x00089454
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0008B298 File Offset: 0x00089498
		public unsafe virtual string positiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_positiveName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0008B2DC File Offset: 0x000894DC
		public unsafe virtual string negativeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_negativeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x0008B320 File Offset: 0x00089520
		public unsafe virtual Object elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0008B36C File Offset: 0x0008956C
		public unsafe virtual bool useEditorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0008B3B4 File Offset: 0x000895B4
		public unsafe virtual ControllerElementType editorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementIdentifierCommon_Internal.NativeMethodInfoPtr_get_editorElementTypeOverride_Public_Abstract_Virtual_New_get_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public IControllerElementIdentifierCommon_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_get_useEditorElementTypeOverride_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_get_editorElementTypeOverride_Public_Abstract_Virtual_New_get_ControllerElementType_0;
	}
}
