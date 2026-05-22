using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000043 RID: 67
	public class IMeshModifier : Il2CppObjectBase
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x00026A1C File Offset: 0x00024C1C
		// Note: this type is marked as 'beforefieldinit'.
		static IMeshModifier()
		{
			Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMeshModifier");
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664626);
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664627);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00026A6C File Offset: 0x00024C6C
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00026ABC File Offset: 0x00024CBC
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(VertexHelper verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00004DAB File Offset: 0x00002FAB
		public IMeshModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0;
	}
}
