using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppTMPro
{
	// Token: 0x02000046 RID: 70
	public class ITextElement : Il2CppObjectBase
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x000249CC File Offset: 0x00022BCC
		// Note: this type is marked as 'beforefieldinit'.
		static ITextElement()
		{
			Il2CppClassPointerStore<ITextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ITextElement");
			ITextElement.NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664239);
			ITextElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664240);
			ITextElement.NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664241);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00024A30 File Offset: 0x00022C30
		public unsafe virtual Material sharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00024A7C File Offset: 0x00022C7C
		[CallerCount(0)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00024AC8 File Offset: 0x00022CC8
		[CallerCount(0)]
		public unsafe virtual int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00005920 File Offset: 0x00003B20
		public ITextElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0;
	}
}
