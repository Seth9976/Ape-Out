using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BB RID: 955
	public class IContextProperty : Il2CppObjectBase
	{
		// Token: 0x06003ED9 RID: 16089 RVA: 0x00128434 File Offset: 0x00126634
		// Note: this type is marked as 'beforefieldinit'.
		static IContextProperty()
		{
			Il2CppClassPointerStore<IContextProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContextProperty");
			IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672600);
			IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672601);
			IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672602);
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x00128498 File Offset: 0x00126698
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x001284DC File Offset: 0x001266DC
		[CallerCount(0)]
		public unsafe virtual void Freeze(Context newContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0012852C File Offset: 0x0012672C
		[CallerCount(0)]
		public unsafe virtual bool IsNewContextOK(Context newCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x000176F2 File Offset: 0x000158F2
		public IContextProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0;

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0;
	}
}
