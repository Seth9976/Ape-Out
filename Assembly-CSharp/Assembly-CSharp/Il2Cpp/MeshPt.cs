using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000187 RID: 391
	[StructLayout(2)]
	public struct MeshPt
	{
		// Token: 0x06002EA0 RID: 11936 RVA: 0x000B4C64 File Offset: 0x000B2E64
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPt()
		{
			Il2CppClassPointerStore<MeshPt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshPt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPt>.NativeClassPtr);
			MeshPt.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPt>.NativeClassPtr, "pos");
			MeshPt.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPt>.NativeClassPtr, "uv");
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000203CB File Offset: 0x0001E5CB
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshPt>.NativeClassPtr, ref this));
		}

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001B6F RID: 7023
		[FieldOffset(0)]
		public Vector3 pos;

		// Token: 0x04001B70 RID: 7024
		[FieldOffset(12)]
		public Vector2 uv;
	}
}
