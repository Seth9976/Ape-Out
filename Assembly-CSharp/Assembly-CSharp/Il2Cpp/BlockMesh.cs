using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000080 RID: 128
	public class BlockMesh : MonoBehaviour
	{
		// Token: 0x06001077 RID: 4215 RVA: 0x00064064 File Offset: 0x00062264
		// Note: this type is marked as 'beforefieldinit'.
		static BlockMesh()
		{
			Il2CppClassPointerStore<BlockMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BlockMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockMesh>.NativeClassPtr);
			BlockMesh.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockMesh>.NativeClassPtr, 100664677);
			BlockMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockMesh>.NativeClassPtr, 100664678);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000640BC File Offset: 0x000622BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48163, XrefRangeEnd = 48223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockMesh.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000640F0 File Offset: 0x000622F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockMesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockMesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0000C327 File Offset: 0x0000A527
		public BlockMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
