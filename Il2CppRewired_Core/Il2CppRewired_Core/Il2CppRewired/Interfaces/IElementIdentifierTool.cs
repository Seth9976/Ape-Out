using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppRewired.Internal;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000E9 RID: 233
	public class IElementIdentifierTool : Il2CppObjectBase
	{
		// Token: 0x06001855 RID: 6229 RVA: 0x0008AA7C File Offset: 0x00088C7C
		// Note: this type is marked as 'beforefieldinit'.
		static IElementIdentifierTool()
		{
			Il2CppClassPointerStore<IElementIdentifierTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IElementIdentifierTool");
			IElementIdentifierTool.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_GUIText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IElementIdentifierTool>.NativeClassPtr, 100669220);
			IElementIdentifierTool.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IElementIdentifierTool>.NativeClassPtr, 100669221);
			IElementIdentifierTool.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IElementIdentifierTool>.NativeClassPtr, 100669222);
			IElementIdentifierTool.NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IElementIdentifierTool>.NativeClassPtr, 100669223);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0008AAF4 File Offset: 0x00088CF4
		[CallerCount(0)]
		public unsafe virtual void Initialize(GUIText guiText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guiText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IElementIdentifierTool.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_GUIText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0008AB44 File Offset: 0x00088D44
		[CallerCount(0)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IElementIdentifierTool.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0008AB80 File Offset: 0x00088D80
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IElementIdentifierTool.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0008ABBC File Offset: 0x00088DBC
		[CallerCount(0)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IElementIdentifierTool.NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public IElementIdentifierTool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_GUIText_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0;
	}
}
