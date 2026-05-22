using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000060 RID: 96
	public class PathNode : MonoBehaviour
	{
		// Token: 0x06000D27 RID: 3367 RVA: 0x0005B8D0 File Offset: 0x00059AD0
		// Note: this type is marked as 'beforefieldinit'.
		static PathNode()
		{
			Il2CppClassPointerStore<PathNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PathNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathNode>.NativeClassPtr);
			PathNode.NativeFieldInfoPtr_isLadder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathNode>.NativeClassPtr, "isLadder");
			PathNode.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathNode>.NativeClassPtr, "pos");
			PathNode.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNode>.NativeClassPtr, 100664463);
			PathNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNode>.NativeClassPtr, 100664464);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0005B950 File Offset: 0x00059B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43762, XrefRangeEnd = 43766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathNode.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0005B984 File Offset: 0x00059B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00009FC7 File Offset: 0x000081C7
		public PathNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0005B9C0 File Offset: 0x00059BC0
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00009FD0 File Offset: 0x000081D0
		public unsafe bool isLadder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathNode.NativeFieldInfoPtr_isLadder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathNode.NativeFieldInfoPtr_isLadder)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0005B9E8 File Offset: 0x00059BE8
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00009FEB File Offset: 0x000081EB
		public unsafe Vector3 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathNode.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathNode.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_isLadder;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
