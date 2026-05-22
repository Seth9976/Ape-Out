using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A8 RID: 424
	public class StartTileTeleporter : MonoBehaviour
	{
		// Token: 0x06003094 RID: 12436 RVA: 0x000B9FCC File Offset: 0x000B81CC
		// Note: this type is marked as 'beforefieldinit'.
		static StartTileTeleporter()
		{
			Il2CppClassPointerStore<StartTileTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StartTileTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartTileTeleporter>.NativeClassPtr);
			StartTileTeleporter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartTileTeleporter>.NativeClassPtr, 100667093);
			StartTileTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartTileTeleporter>.NativeClassPtr, 100667094);
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x000BA024 File Offset: 0x000B8224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84543, XrefRangeEnd = 84547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartTileTeleporter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000BA058 File Offset: 0x000B8258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartTileTeleporter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartTileTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartTileTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000216A0 File Offset: 0x0001F8A0
		public StartTileTeleporter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
